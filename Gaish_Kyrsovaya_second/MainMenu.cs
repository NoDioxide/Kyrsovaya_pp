using Gaish_Kyrsovaya_second.Properties;
using ReaLTaiizor.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Gaish_Kyrsovaya_second.LogRegFrm;

namespace Gaish_Kyrsovaya_second
{
    public partial class MainMenu : Form
    {
        Profile prof;
        AvailableTasks avTasks;
        Favourite likes;
        Settings settings;
        Testing test;
        About about;

        MaterialSkin.Controls.MaterialSwitch themeToggle;
        private string loggedInUser;

        public MainMenu(string loggedInUser)
        {
            InitializeComponent();
            mdiProp();
            this.loggedInUser = loggedInUser;
        }
        bool menuExpand = false;

        private void LogRegFrm_UserLoggedIn(object sender, string e)
        {
            // Получаем логин пользователя и сохраняем его
            loggedInUser = e;
            // Открываем форму Profile и передаем логин пользователя
            Profile profileForm = new Profile(loggedInUser);
            profileForm.ShowDialog();
        }

        private void mdiProp()
        {
            this.SetBevel(false);
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(232, 234, 237);
        }
        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                MenuContainer.Height += 10;
                if (MenuContainer.Height >= 140)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                MenuContainer.Height -= 10;
                if (MenuContainer.Height <= 46)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }

        bool sidebarExpand = true;
        private void sideBarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                SideBar.Width -= 5;
                if (SideBar.Width <= 46)
                {
                    sidebarExpand = false;
                    sideBarTransition.Stop();

                    pnProfile.Width = SideBar.Width;
                    pnTickets.Width = SideBar.Width;
                    pnExit.Width = SideBar.Width;
                    pnNews.Width = SideBar.Width;
                    pnAbout.Width = SideBar.Width;
                    MenuContainer.Width = SideBar.Width;
                }
            }
            else
            {
                SideBar.Width += 5;
                if (SideBar.Width >= 228)
                {
                    sidebarExpand = true;
                    sideBarTransition.Stop();

                    pnProfile.Width = SideBar.Width;
                    pnTickets.Width = SideBar.Width;
                    pnExit.Width = SideBar.Width;
                    pnNews.Width = SideBar.Width;
                    pnAbout.Width = SideBar.Width;
                    MenuContainer.Width = SideBar.Width;
                }
            }
        }

        private void btnHam_Click(object sender, EventArgs e)
        {
            sideBarTransition.Start();
        }

        private void Profile_Load(object sender, EventArgs e)
        {

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            if (prof == null)
            {
                prof = new Profile(loggedInUser);
                prof.FormClosed += Profile_FormClosed;
                prof.MdiParent = this;
                prof.Show();
            }
            else
            {
                prof.Activate();
            }
        }

        private void Profile_FormClosed(object sender, FormClosedEventArgs e)
        {
            prof = null;
        }

        private void AvailableTasks_FormClosed(object sender, FormClosedEventArgs e)
        {
            avTasks = null;
        }

        private void btnTasks_Click(object sender, EventArgs e)
        {
            if (prof == null)
            {
                MessageBox.Show("Пожалуйста, сначала откройте профиль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (avTasks == null)
            {
                avTasks = new AvailableTasks(this, loggedInUser, prof, test);
                avTasks.FormClosed += AvailableTasks_FormClosed;
                avTasks.MdiParent = this;
                avTasks.Dock = DockStyle.Fill;
                avTasks.Show();
            }
            else
            {
                avTasks.Activate();
            }
        }

        private void btnLikes_Click(object sender, EventArgs e)
        {
            if (likes == null)
            {
                likes = new Favourite();
                likes.FormClosed += Favorite_FormClosed;
                likes.MdiParent = this;
                likes.Dock = DockStyle.Fill;
                likes.Show();
            }
            else
            {
                likes.Activate();
            }
        }

        private void Favorite_FormClosed(object sender, FormClosedEventArgs e)
        {
            likes = null;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            if (settings == null)
            {
                settings = new Settings(this, themeToggle);
                settings.FormClosed += Settings_FormClosed;
                settings.MdiParent = this;
                settings.Dock = DockStyle.Fill;
                settings.Show();
            }
            else
            {
                settings.Activate();
            }
        }

        private void Settings_FormClosed(object sender, FormClosedEventArgs e)
        {
            settings = null;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            LogRegFrm logRegFrm = new LogRegFrm();
            logRegFrm.Show();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            if (test == null)
            {
                if (avTasks != null)
                {
                    test = new Testing(avTasks.GetCompletedCourses());
                    test.FormClosed += Test_FormClosed;
                    test.MdiParent = this;
                    test.Dock = DockStyle.Fill;
                    test.Show();
                }
                else
                {
                    MessageBox.Show("Для открытия тестирования необходимо сначала открыть задания.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                test.Activate();
            }
        }


        private void Test_FormClosed(object sender, FormClosedEventArgs e)
        {
            test = null;
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            if (about == null)
            {
                about = new About();
                about.FormClosed += About_FormClosed;
                about.MdiParent = this;
                about.Dock = DockStyle.Fill;
                about.Show();
            }
            else
            {
                about.Activate();
            }
        }

        private void About_FormClosed(object sender, FormClosedEventArgs e)
        {
            about = null;
        }
        public Panel GetSideBar()
        {
            return SideBar;
        }
        public PictureBox GetHamButton()
        {
            return btnHam;
        }
    }
}
