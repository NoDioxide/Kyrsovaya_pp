using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gaish_Kyrsovaya_second
{
    public partial class Testing : Form
    {
        private int completedCourses;

        public Testing(int completedCourses)
        {
            InitializeComponent();
            this.completedCourses = completedCourses;
        }

        private void Testing_Load(object sender, EventArgs e)
        {
            if (completedCourses == 3)
            {
                btnNext.Visible = true;
                JustLabel.Visible = false;
                materialLabel2.Visible = true;
                button2.Visible = true;
                button3.Visible = true;

                CBCorrect1.Visible = true;
                materialCheckbox2.Visible = true;
                materialCheckbox3.Visible = true;
                materialCheckbox4.Visible = true;

                materialLabel3.Visible = true;

                materialCheckbox5.Visible = true;
                materialCheckbox6.Visible = true;
                CBCorrect2.Visible = true;
                materialCheckbox8.Visible = true;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            materialLabel2.Visible = false;
            CBCorrect1.Visible = false;
            materialCheckbox2.Visible = false;
            materialCheckbox3.Visible = false;
            materialCheckbox4.Visible = false;
            materialLabel3.Visible = false;
            materialCheckbox5.Visible = false;
            materialCheckbox6.Visible = false;
            CBCorrect2.Visible = false;
            materialCheckbox8.Visible = false;

            btnNext.Visible = false;
            btnNextNext.Visible = true;
            materialLabel4.Visible = true;

            materialCheckbox9.Visible = true;
            materialCheckbox10.Visible = true;
            CBCorrect3.Visible = true;
            materialCheckbox11.Visible = true;

            materialLabel5.Visible = true;

            materialCheckbox12.Visible = true;
            materialCheckbox13.Visible = true;
            materialCheckbox14.Visible = true;
            CBCorrect4.Visible = true;
        }

        private void btnNextNext_Click(object sender, EventArgs e)
        {
            btnNextNext.Visible = false;
            materialLabel4.Visible = false;
            materialCheckbox9.Visible = false;
            materialCheckbox10.Visible = false;
            CBCorrect3.Visible = false;
            materialCheckbox11.Visible = false;
            materialLabel5.Visible = false;
            materialCheckbox12.Visible = false;
            materialCheckbox13.Visible = false;
            materialCheckbox14.Visible = false;
            CBCorrect4.Visible = false;
            button3.Visible = false;

            materialLabel6.Visible = true;

            materialCheckbox15.Visible = true;
            CBCorrect5.Visible = true;
            materialCheckbox16.Visible = true;
            materialCheckbox17.Visible = true;

            btnEnd.Visible = true;
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            materialLabel6.Visible = false;
            materialCheckbox15.Visible = false;
            CBCorrect5.Visible = false;
            materialCheckbox16.Visible = false;
            materialCheckbox17.Visible = false;
            button2.Visible = false;
            btnEnd.Visible = false;

            materialLabel1.Visible = true;

            int points = 0;
            if (CBCorrect1.Checked == true && materialCheckbox2.Checked == false && materialCheckbox3.Checked == false && materialCheckbox4.Checked == false)
            {
                points++;
                materialLabel1.Text = "Ваша оценка: " + points;
            }
            if (CBCorrect2.Checked == true && materialCheckbox5.Checked == false && materialCheckbox6.Checked == false && materialCheckbox8.Checked == false)
            {
                points++;
                materialLabel1.Text = "Ваша оценка: " + points;
            }
            if (CBCorrect3.Checked == true && materialCheckbox9.Checked == false && materialCheckbox10.Checked == false && materialCheckbox11.Checked == false)
            {
                points++;
                materialLabel1.Text = "Ваша оценка: " + points;
            }
            if (CBCorrect4.Checked == true && materialCheckbox12.Checked == false && materialCheckbox13.Checked == false && materialCheckbox14.Checked == false)
            {
                points++;
                materialLabel1.Text = "Ваша оценка: " + points;
            }
            if (CBCorrect5.Checked == true && materialCheckbox15.Checked == false && materialCheckbox16.Checked == false && materialCheckbox17.Checked == false)
            {
                points++;
                materialLabel1.Text = "Ваша оценка: " + points;
            }
            if (points <= 2)
            {
                points = 2;
                materialLabel1.Text = "Ваша оценка: " + points;
            }
        }
    }
}
