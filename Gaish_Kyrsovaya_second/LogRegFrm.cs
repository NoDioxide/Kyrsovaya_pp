using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Gaish_Kyrsovaya_second
{
    public partial class LogRegFrm : MaterialForm
    {
        DataBase database = new DataBase();

        public event EventHandler<string> UserLoggedIn;

        public LogRegFrm()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
        }

        MaterialSkinManager Thememanager = MaterialSkinManager.Instance;

        public FormClosedEventHandler Settings_FormClosed { get; private set; }

        private void LogButton_Click(object sender, EventArgs e)
        {
            var logUser = UserTB.Text;
            var passUser = PassTB.Text;

            if (string.IsNullOrEmpty(logUser) || string.IsNullOrEmpty(passUser))
            {
                MessageBox.Show("Пожалуйста, введите логин и пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = $"SELECT COUNT(*) FROM UsersInfo WHERE Login = @logUser AND Password = @passUser";
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-7QTLDNV\SQLEXPRESS;Initial Catalog=Kyrsovaya;Integrated Security=True"))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@logUser", logUser);
                command.Parameters.AddWithValue("@passUser", passUser);
                connection.Open();
                int userCount = (int)command.ExecuteScalar();
                if (userCount > 0)
                {
                    string userInfoQuery = $"SELECT ProfilePhoto, FirstName, LastName, Status FROM UsersInfo WHERE Login = @logUser";
                    SqlCommand userInfoCommand = new SqlCommand(userInfoQuery, connection);
                    userInfoCommand.Parameters.AddWithValue("@logUser", logUser);
                    SqlDataReader reader = userInfoCommand.ExecuteReader();
                    if (reader.Read())
                    {
                        UserInfo loggedInUser = new UserInfo();
                        if (reader["ProfilePhoto"] != DBNull.Value)
                        {
                            loggedInUser.ProfilePhoto = (byte[])reader["ProfilePhoto"];
                        }
                        else
                        {
                            loggedInUser.ProfilePhoto = null;
                        }
                        loggedInUser.FirstName = reader["FirstName"].ToString();
                        loggedInUser.LastName = reader["LastName"].ToString();
                        loggedInUser.Status = reader["Status"].ToString();

                        MessageBox.Show("Успешный вход в аккаунт!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        MainMenu MM = new MainMenu(logUser);
                        MM.FormClosed += MainMenu_FormClosed; 
                        this.Hide();
                        MM.ShowDialog();
                    }
                    reader.Close();
                    UserLoggedIn?.Invoke(this, logUser);
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public class UserInfo
        {
            public byte[] ProfilePhoto { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Status { get; set; }
        }

        private void LabelReg_Click(object sender, EventArgs e)
        {
            LogButton.Visible = false;
            RegButton.Visible = true;
            LabelReg.Visible = false;
            LabelLog.Visible = true;
        }

        private void LabelLog_Click(object sender, EventArgs e)
        {
            LogButton.Visible = true;
            RegButton.Visible = false;
            LabelReg.Visible = true;
            LabelLog.Visible = false;
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            database.openConnection();

            var regUser = UserTB.Text;
            var regPass = PassTB.Text;

            if (string.IsNullOrEmpty(regUser) || string.IsNullOrEmpty(regPass))
            {
                MessageBox.Show("Ошибка при вводе данных", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                database.closeConnection();
                return;
            }

            var checkQuery = $"SELECT COUNT(*) FROM Usersinfo WHERE Login = '{regUser}'";
            var checkCommand = new SqlCommand(checkQuery, database.GetConnection());
            int userCount = (int)checkCommand.ExecuteScalar();

            if (userCount > 0)
            {
                MessageBox.Show("Пользователь с таким логином уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                database.closeConnection();
                return;
            }

            var addQuery = $"INSERT INTO UsersInfo (Login, Password) VALUES ('{regUser}', '{regPass}')";
            var addcommand = new SqlCommand(addQuery, database.GetConnection());
            addcommand.ExecuteNonQuery();

            MessageBox.Show("Учётная запись создана!", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            database.closeConnection();
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
