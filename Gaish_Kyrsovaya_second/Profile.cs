using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Gaish_Kyrsovaya_second.LogRegFrm;

namespace Gaish_Kyrsovaya_second
{
    public partial class Profile : Form
    {
        private string loggedInUser;
        private int completedCourses;

        public int CompletedCourses
        {
            get { return completedCourses; }
            set { completedCourses = value; }
        }
        public Profile(string loggedInUser)
        {
            InitializeComponent();
            this.loggedInUser = loggedInUser;
            LoadUserInfo();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            LoadCourseCompletion();
        }

        private void LoadUserInfo()
        {

            string query = $"SELECT ProfilePhoto, FirstName, LastName, Status FROM UsersInfo WHERE Login = '{loggedInUser}'";
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-7QTLDNV\SQLEXPRESS;Initial Catalog=Kyrsovaya;Integrated Security=True"))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    UserInfo userInfo = new UserInfo();
                    if (reader["ProfilePhoto"] != DBNull.Value)
                    {
                        userInfo.ProfilePhoto = (byte[])reader["ProfilePhoto"];
                    }
                    else
                    {
                        userInfo.ProfilePhoto = null;
                    }
                    userInfo.FirstName = reader["FirstName"].ToString();
                    userInfo.LastName = reader["LastName"].ToString();
                    userInfo.Status = reader["Status"].ToString();

                    if (userInfo.ProfilePhoto != null)
                    {
                        PB.Image = Image.FromStream(new MemoryStream(userInfo.ProfilePhoto));
                    }
                    TBName.Text = userInfo.FirstName;
                    TBUserName.Text = userInfo.LastName;
                    TBStatus.Text = userInfo.Status;
                }
                reader.Close();
            }
        }

        private void MBUploadPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.png, *.bmp)|*.jpg;*.png;*.bmp|All Files (*.*)|*.*";
            openFileDialog.Title = "Выберите изображение";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    byte[] imageData;
                    using (FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open))
                    {
                        using (BinaryReader br = new BinaryReader(fs))
                        {
                            imageData = br.ReadBytes((int)fs.Length);
                        }
                    }

                    string updateQuery = "UPDATE UsersInfo SET ProfilePhoto = @ImageData WHERE Login = @Login";
                    using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-7QTLDNV\SQLEXPRESS;Initial Catalog=Kyrsovaya;Integrated Security=True"))
                    {
                        connection.Open();
                        SqlCommand command = new SqlCommand(updateQuery, connection);
                        command.Parameters.AddWithValue("@ImageData", imageData);
                        command.Parameters.AddWithValue("@Login", loggedInUser);
                        command.ExecuteNonQuery();
                    }

                    PB.Image = Image.FromFile(openFileDialog.FileName);
                    MessageBox.Show("Фотография успешно загружена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при загрузке изображения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void MBChangeInfo_Click(object sender, EventArgs e)
        {
            string newFirstName = TBName.Text;
            string newLastName = TBUserName.Text;
            string newStatus = TBStatus.Text;

            string updateQuery = $"UPDATE UsersInfo SET FirstName = @FirstName, LastName = @LastName, Status = @Status WHERE Login = @Login";
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-7QTLDNV\SQLEXPRESS;Initial Catalog=Kyrsovaya;Integrated Security=True"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(updateQuery, connection);
                command.Parameters.AddWithValue("@FirstName", newFirstName);
                command.Parameters.AddWithValue("@LastName", newLastName);
                command.Parameters.AddWithValue("@Status", newStatus);
                command.Parameters.AddWithValue("@Login", loggedInUser);
                command.ExecuteNonQuery();
            }

            MessageBox.Show("Информация успешно обновлена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LoadUserInfo();
        }
        /*private void LoadCourseCompletion()
        {
            int completedCourses = 0;

            // Получение количества пройденных курсов на основе TestMark
            string query = $"SELECT TestMark FROM UsersInfo WHERE Login = '{loggedInUser}'";
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-7QTLDNV\SQLEXPRESS;Initial Catalog=Kyrsovaya;Integrated Security=True"))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    int testMark = (int)reader["TestMark"];
                    if (testMark >= 4)
                    {
                        completedCourses++;
                    }
                }
                reader.Close();
            }

            // Обновление текста dungeonHeaderLabel1 с учетом количества пройденных курсов
            dungeonHeaderLabel1.Text = $"Пройдено курсов {completedCourses}/3";
        }*/

        private void LoadCourseCompletion()
        {
            int completedCourses = 0;

            string query = $"SELECT TestMark FROM UsersInfo WHERE Login = '{loggedInUser}'";
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-7QTLDNV\SQLEXPRESS;Initial Catalog=Kyrsovaya;Integrated Security=True"))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (!reader.IsDBNull(reader.GetOrdinal("TestMark")))
                    {
                        int testMark = (int)reader["TestMark"];
                        if (testMark >= 4)
                        {
                            completedCourses++;
                        }
                    }
                }
                reader.Close();
            }
            string querySec = $"SELECT TestMarkSecond FROM UsersInfo WHERE Login = '{loggedInUser}'";
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-7QTLDNV\SQLEXPRESS;Initial Catalog=Kyrsovaya;Integrated Security=True"))
            {
                SqlCommand command = new SqlCommand(querySec, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (!reader.IsDBNull(reader.GetOrdinal("TestMarkSecond")))
                    {
                        int testMarkSec = (int)reader["TestMarkSecond"];
                        if (testMarkSec >= 4)
                        {
                            completedCourses++;
                        }
                    }
                }
                reader.Close();
            }
            string queryThird = $"SELECT TestMarkThird FROM UsersInfo WHERE Login = '{loggedInUser}'";
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-7QTLDNV\SQLEXPRESS;Initial Catalog=Kyrsovaya;Integrated Security=True"))
            {
                SqlCommand command = new SqlCommand(queryThird, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (!reader.IsDBNull(reader.GetOrdinal("TestMarkThird")))
                    {
                        int testMarkThird = (int)reader["TestMarkThird"];
                        if (testMarkThird >= 4)
                        {
                            completedCourses++;
                        }
                    }
                }
                reader.Close();
            }

            //CompletedCourses = completedCourses;
            this.completedCourses = completedCourses;
            dungeonHeaderLabel1.Text = $"Пройдено курсов {completedCourses}/3";
        }
    }
}
