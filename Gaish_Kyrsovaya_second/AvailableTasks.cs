using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.Devices;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Gaish_Kyrsovaya_second
{
    public partial class AvailableTasks : Form
    {
        MainMenu mainMenuForm;
        private string loggedInUser;
        private string currentCourse;

        private List<System.Drawing.Image> images = new List<System.Drawing.Image>();
        private List<System.Drawing.Image> images2 = new List<System.Drawing.Image>();
        private List<System.Drawing.Image> images3 = new List<System.Drawing.Image>();
        private int currentIndex = 0;
        public AvailableTasks(MainMenu mainMenu, string loggedInUser)
        {
            InitializeComponent();
            this.mainMenuForm = mainMenu;
            this.loggedInUser = loggedInUser;

            CourseBtn1.Tag = "CourseBtn1";
            CourseBtn2.Tag = "CourseBtn2";
            CourseBtn3.Tag = "CourseBtn3";

            LoadImages();
            if (images.Count > 0)
                PBCourse1.Image = images[currentIndex];
            if (images2.Count > 0)
                PBCourse2.Image = images2[currentIndex];
            if (images3.Count > 0)
                PBCourse3.Image = images3[currentIndex];
        }
        private void LoadImages()
        {
            string basePath = "C:\\Users\\nodio\\Desktop\\Gaish_Kyrsovaya_second\\Gaish_Kyrsovaya_second\\Images\\";

            // PictureBox 1
            images.Add(System.Drawing.Image.FromFile(basePath + "img1.png"));
            images.Add(System.Drawing.Image.FromFile(basePath + "img2.png"));
            images.Add(System.Drawing.Image.FromFile(basePath + "img3.png"));
            images.Add(System.Drawing.Image.FromFile(basePath + "img4.png"));
            images.Add(System.Drawing.Image.FromFile(basePath + "img5.png"));
            // PictureBox 2
            images2.Add(System.Drawing.Image.FromFile(basePath + "img6.png"));
            images2.Add(System.Drawing.Image.FromFile(basePath + "img7.png"));
            images2.Add(System.Drawing.Image.FromFile(basePath + "img8.png"));
            images2.Add(System.Drawing.Image.FromFile(basePath + "img9.png"));
            images2.Add(System.Drawing.Image.FromFile(basePath + "img10.png"));
            // PictureBox 3
            images3.Add(System.Drawing.Image.FromFile(basePath + "img11.png"));
            images3.Add(System.Drawing.Image.FromFile(basePath + "img12.png"));
            images3.Add(System.Drawing.Image.FromFile(basePath + "img13.png"));
            images3.Add(System.Drawing.Image.FromFile(basePath + "img14.png"));
            images3.Add(System.Drawing.Image.FromFile(basePath + "img15.png"));
        }

        private void AvailableTasks_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;

            int testMark = 0;
            string query = $"SELECT TestMark FROM UsersInfo WHERE Login = '{loggedInUser}'";
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-7QTLDNV\SQLEXPRESS;Initial Catalog=Kyrsovaya;Integrated Security=True"))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read() && reader["TestMark"] != DBNull.Value)
                {
                    testMark = (int)reader["TestMark"];
                }
                reader.Close();
            }

            double percentage = 0;
            switch (testMark)
            {
                case 3:
                    percentage = 50;
                    break;
                case 4:
                    percentage = 75;
                    break;
                case 5:
                    percentage = 100;
                    break;
            }
            dungeonLabel1.Text = $"{percentage}%";
            materialProgressBar1.Value = (int)percentage;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (PBCourse1.Visible)
            {
                currentIndex++;
                if (currentIndex >= images.Count)
                    currentIndex = 0;

                PBCourse1.Image = images[currentIndex];

                if (currentIndex == 4)
                    btnToTest.Visible = true;
                else
                    btnToTest.Visible = false;
            }
            else if (PBCourse2.Visible)
            {
                currentIndex++;
                if (currentIndex >= images2.Count)
                    currentIndex = 0;

                PBCourse2.Image = images2[currentIndex];

                if (currentIndex == 4)
                    btnToTest.Visible = true;
                else
                    btnToTest.Visible = false;
            }
            else if (PBCourse3.Visible)
            {
                currentIndex++;
                if (currentIndex >= images3.Count)
                    currentIndex = 0;

                PBCourse3.Image = images3[currentIndex];

                if (currentIndex == 4)
                    btnToTest.Visible = true;
                else
                    btnToTest.Visible = false;
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (PBCourse1.Visible)
            {
                currentIndex--;
                if (currentIndex < 0)
                    currentIndex = images.Count - 1;

                PBCourse1.Image = images[currentIndex];

                if (currentIndex == 4)
                    btnToTest.Visible = true;
                else
                    btnToTest.Visible = false;
            }
            else if (PBCourse2.Visible)
            {
                currentIndex--;
                if (currentIndex < 0)
                    currentIndex = images2.Count - 1;

                PBCourse2.Image = images2[currentIndex];

                if (currentIndex == 4)
                    btnToTest.Visible = true;
                else
                    btnToTest.Visible = false;
            }
            else if (PBCourse3.Visible)
            {
                currentIndex--;
                if (currentIndex < 0)
                    currentIndex = images3.Count - 1;

                PBCourse3.Image = images3[currentIndex];

                if (currentIndex == 4)
                    btnToTest.Visible = true;
                else
                    btnToTest.Visible = false;
            }
        }

        private void CourseBtn1_Click(object sender, EventArgs e)
        {
            btnNext_Click(sender, e);
            System.Windows.Forms.Panel sideBar = mainMenuForm.GetSideBar();
            PictureBox btnHam = mainMenuForm.GetHamButton();
            currentCourse = "CourseBtn1";

            Course1.Visible = false;
            Course2.Visible = false;
            Course3.Visible = false;
            JustText.Visible = false;
            CourseBtn1.Visible = false;
            CourseBtn2.Visible = false;
            CourseBtn3.Visible = false;

            sideBar.Enabled = false;
            sideBar.Width = 46;
            btnHam.Enabled = false;

            PBCourse1.Visible = true;
            btnPrev.Visible = true;
            btnNext.Visible = true;

            PBCorrect.Visible = true;
            PBUncorrect.Visible = true;
        }

        private void CourseBtn2_Click(object sender, EventArgs e)
        {
            btnNext_Click(sender, e);
            System.Windows.Forms.Panel sideBar = mainMenuForm.GetSideBar();
            PictureBox btnHam = mainMenuForm.GetHamButton();
            currentCourse = "CourseBtn2";

            Course1.Visible = false;
            Course2.Visible = false;
            Course3.Visible = false;
            JustText.Visible = false;
            CourseBtn1.Visible = false;
            CourseBtn2.Visible = false;
            CourseBtn3.Visible = false;

            sideBar.Enabled = false;
            sideBar.Width = 46;
            btnHam.Enabled = false;

            PBCourse2.Visible = true;
            btnPrev.Visible = true;
            btnNext.Visible = true;

            PBCorrect.Visible = true;
            PBUncorrect.Visible = true;
        }

        private void CourseBtn3_Click(object sender, EventArgs e)
        {
            btnNext_Click(sender, e);
            System.Windows.Forms.Panel sideBar = mainMenuForm.GetSideBar();
            PictureBox btnHam = mainMenuForm.GetHamButton();
            currentCourse = "CourseBtn3";

            Course1.Visible = false;
            Course2.Visible = false;
            Course3.Visible = false;
            JustText.Visible = false;
            CourseBtn1.Visible = false;
            CourseBtn2.Visible = false;
            CourseBtn3.Visible = false;

            sideBar.Enabled = false;
            sideBar.Width = 46;
            btnHam.Enabled = false;

            PBCourse3.Visible = true;
            btnPrev.Visible = true;
            btnNext.Visible = true;

            PBCorrect.Visible = true;
            PBUncorrect.Visible = true;
        }

        private void btnToTest_Click(object sender, EventArgs e)
        {
            MaterialButton clickedButton = sender as MaterialButton;

            if (currentCourse == "CourseBtn1")
            {
                PBCourse1.Visible = false;
                PBCourse2.Visible = false;
                PBCourse3.Visible = false;
                PBCorrect.Visible = false;
                PBUncorrect.Visible = false;
                btnPrev.Visible = false;
                btnNext.Visible = false;
                btnToTest.Visible = false;

                CBCorrect1.Visible = true;
                CBCorrect2.Visible = true;
                btnNextQuest.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                materialLabel2.Visible = true;
                materialLabel3.Visible = true;
                materialCheckbox2.Visible = true;
                materialCheckbox3.Visible = true;
                materialCheckbox4.Visible = true;
                materialCheckbox5.Visible = true;
                materialCheckbox6.Visible = true;
                materialCheckbox8.Visible = true;
            }
            else if (currentCourse == "CourseBtn2")
            {
                
            }
            else if (currentCourse == "CourseBtn3")
            {
                
            }
        }

        private void btnNextQuest_Click(object sender, EventArgs e)
        {
            CBCorrect1.Visible = false;
            CBCorrect2.Visible = false;
            btnNextQuest.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            materialLabel1.Visible = false;
            materialLabel2.Visible = false;
            materialLabel3.Visible = false;
            materialCheckbox2.Visible = false;
            materialCheckbox3.Visible = false;
            materialCheckbox4.Visible = false;
            materialCheckbox5.Visible = false;
            materialCheckbox6.Visible = false;
            materialCheckbox8.Visible = false;

            materialLabel4.Visible = true;
            materialLabel5.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            CBCorrect3.Visible = true;
            CBCorrect4.Visible = true;
            materialCheckbox9.Visible = true;
            materialCheckbox11.Visible = true;
            materialCheckbox12.Visible = true;
            materialCheckbox14.Visible = true;
            materialCheckbox15.Visible = true;
            materialCheckbox16.Visible = true;
            btnNextNextQuest.Visible = true;
        }

        private void btnNextNextQuest_Click(object sender, EventArgs e)
        {
            materialLabel4.Visible = false;
            materialLabel5.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            CBCorrect3.Visible = false;
            CBCorrect4.Visible = false;
            materialCheckbox9.Visible = false;
            materialCheckbox11.Visible = false;
            materialCheckbox12.Visible = false;
            materialCheckbox14.Visible = false;
            materialCheckbox15.Visible = false;
            materialCheckbox16.Visible = false;
            btnNextNextQuest.Visible = false;

            materialLabel6.Visible = true;
            button6.Visible = true;
            CBCorrect5.Visible = true;
            materialCheckbox17.Visible = true;
            materialCheckbox18.Visible = true;
            materialCheckbox19.Visible = true;
            btnTestEnd.Visible = true;
        }

        private void btnTestEnd_Click(object sender, EventArgs e)
        {
            btnTestEnd.Visible = false;
            materialLabel6.Visible = false;
            button6.Visible = false;
            CBCorrect5.Visible = false;
            materialCheckbox17.Visible = false;
            materialCheckbox18.Visible = false;
            materialCheckbox19.Visible = false;

            materialLabel1.Visible = true;
            btnBacktoStart.Visible = true;

            int points = 0;
            if(CBCorrect1.Checked == true && materialCheckbox2.Checked == false && materialCheckbox3.Checked == false && materialCheckbox4.Checked == false)
            {
                points++;
                materialLabel1.Text = "Ваша оценка: " + points;
            }
            if (CBCorrect2.Checked == true && materialCheckbox5.Checked == false && materialCheckbox6.Checked == false && materialCheckbox8.Checked == false)
            {
                    points++;
                materialLabel1.Text = "Ваша оценка: " + points;
            }
            if (CBCorrect3.Checked == true && materialCheckbox9.Checked == false && materialCheckbox11.Checked == false && materialCheckbox12.Checked == false)
            {
                points++;
                materialLabel1.Text = "Ваша оценка: " + points;
            }
            if (CBCorrect4.Checked == true && materialCheckbox14.Checked == false && materialCheckbox15.Checked == false && materialCheckbox16.Checked == false)
            {
                points++;
                materialLabel1.Text = "Ваша оценка: " + points;
            }
            if (CBCorrect5.Checked == true && materialCheckbox17.Checked == false && materialCheckbox18.Checked == false && materialCheckbox19.Checked == false)
            {
                points++;
                materialLabel1.Text = "Ваша оценка: " + points;
            }
            if(points <= 2)
            {
                points = 2;
                materialLabel1.Text = "Ваша оценка: " + points;
            }

            string updateQuery = $"UPDATE UsersInfo SET TestMark = @TestMark WHERE Login = @Login";
            using (SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-7QTLDNV\SQLEXPRESS;Initial Catalog=Kyrsovaya;Integrated Security=True"))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(updateQuery, connection);
                command.Parameters.AddWithValue("@TestMark", points);
                command.Parameters.AddWithValue("@Login", loggedInUser);
                command.ExecuteNonQuery();
            }
        }

        private void btnBacktoStart_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Panel sideBar = mainMenuForm.GetSideBar();
            PictureBox btnHam = mainMenuForm.GetHamButton();

            sideBar.Enabled = true;
            sideBar.Width = 46;
            btnHam.Enabled = true;

            Course1.Visible = true;
            Course2.Visible = true;
            Course3.Visible = true;
            JustText.Visible = true;
            CourseBtn1.Visible = true;
            CourseBtn2.Visible = true;
            CourseBtn3.Visible = true;

            btnBacktoStart.Visible = false;
            materialLabel1.Visible = false;
        }
    }
}
