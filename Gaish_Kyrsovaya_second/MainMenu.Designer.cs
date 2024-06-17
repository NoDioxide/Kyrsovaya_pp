namespace Gaish_Kyrsovaya_second
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHam = new System.Windows.Forms.PictureBox();
            this.SideBar = new System.Windows.Forms.FlowLayoutPanel();
            this.pnProfile = new System.Windows.Forms.Panel();
            this.btnProfile = new System.Windows.Forms.Button();
            this.MenuContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.Menu = new System.Windows.Forms.Button();
            this.pnTickets = new System.Windows.Forms.Panel();
            this.btnTasks = new System.Windows.Forms.Button();
            this.pnExit = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnNews = new System.Windows.Forms.Panel();
            this.btnNews = new System.Windows.Forms.Button();
            this.pnAbout = new System.Windows.Forms.Panel();
            this.btnAbout = new System.Windows.Forms.Button();
            this.menuTransition = new System.Windows.Forms.Timer(this.components);
            this.sideBarTransition = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).BeginInit();
            this.SideBar.SuspendLayout();
            this.pnProfile.SuspendLayout();
            this.MenuContainer.SuspendLayout();
            this.pnMenu.SuspendLayout();
            this.pnTickets.SuspendLayout();
            this.pnExit.SuspendLayout();
            this.pnNews.SuspendLayout();
            this.pnAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.nightControlBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnHam);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(846, 33);
            this.panel1.TabIndex = 1;
            // 
            // nightControlBox1
            // 
            this.nightControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nightControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.nightControlBox1.CloseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.nightControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nightControlBox1.DefaultLocation = true;
            this.nightControlBox1.DisableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.DisableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.nightControlBox1.EnableCloseColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMaximizeButton = true;
            this.nightControlBox1.EnableMaximizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.EnableMinimizeButton = true;
            this.nightControlBox1.EnableMinimizeColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.nightControlBox1.Location = new System.Drawing.Point(707, 0);
            this.nightControlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MaximizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nightControlBox1.MinimizeHoverForeColor = System.Drawing.Color.White;
            this.nightControlBox1.Name = "nightControlBox1";
            this.nightControlBox1.Size = new System.Drawing.Size(139, 31);
            this.nightControlBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(44, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "ЛИЧНЫЙ КАБИНЕТ И ЧУТКА ИНТЕРЕСНОГО";
            // 
            // btnHam
            // 
            this.btnHam.Image = ((System.Drawing.Image)(resources.GetObject("btnHam.Image")));
            this.btnHam.Location = new System.Drawing.Point(3, 0);
            this.btnHam.Name = "btnHam";
            this.btnHam.Size = new System.Drawing.Size(38, 30);
            this.btnHam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHam.TabIndex = 1;
            this.btnHam.TabStop = false;
            this.btnHam.Click += new System.EventHandler(this.btnHam_Click);
            // 
            // SideBar
            // 
            this.SideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.SideBar.Controls.Add(this.pnProfile);
            this.SideBar.Controls.Add(this.MenuContainer);
            this.SideBar.Controls.Add(this.pnNews);
            this.SideBar.Controls.Add(this.pnAbout);
            this.SideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideBar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.SideBar.Location = new System.Drawing.Point(0, 33);
            this.SideBar.Name = "SideBar";
            this.SideBar.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.SideBar.Size = new System.Drawing.Size(228, 523);
            this.SideBar.TabIndex = 2;
            // 
            // pnProfile
            // 
            this.pnProfile.Controls.Add(this.btnProfile);
            this.pnProfile.Location = new System.Drawing.Point(3, 33);
            this.pnProfile.Name = "pnProfile";
            this.pnProfile.Size = new System.Drawing.Size(225, 41);
            this.pnProfile.TabIndex = 3;
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnProfile.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.Image = ((System.Drawing.Image)(resources.GetObject("btnProfile.Image")));
            this.btnProfile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.Location = new System.Drawing.Point(-14, -51);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnProfile.Size = new System.Drawing.Size(250, 144);
            this.btnProfile.TabIndex = 2;
            this.btnProfile.Text = "           Профиль";
            this.btnProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // MenuContainer
            // 
            this.MenuContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.MenuContainer.Controls.Add(this.pnMenu);
            this.MenuContainer.Controls.Add(this.pnTickets);
            this.MenuContainer.Controls.Add(this.pnExit);
            this.MenuContainer.Location = new System.Drawing.Point(3, 80);
            this.MenuContainer.Name = "MenuContainer";
            this.MenuContainer.Size = new System.Drawing.Size(225, 46);
            this.MenuContainer.TabIndex = 8;
            // 
            // pnMenu
            // 
            this.pnMenu.Controls.Add(this.Menu);
            this.pnMenu.Location = new System.Drawing.Point(3, 3);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(225, 41);
            this.pnMenu.TabIndex = 8;
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.Menu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Menu.ForeColor = System.Drawing.Color.White;
            this.Menu.Image = ((System.Drawing.Image)(resources.GetObject("Menu.Image")));
            this.Menu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Menu.Location = new System.Drawing.Point(-4, -5);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(239, 50);
            this.Menu.TabIndex = 2;
            this.Menu.Text = "           Меню";
            this.Menu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Menu.UseVisualStyleBackColor = false;
            this.Menu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // pnTickets
            // 
            this.pnTickets.Controls.Add(this.btnTasks);
            this.pnTickets.Location = new System.Drawing.Point(3, 50);
            this.pnTickets.Name = "pnTickets";
            this.pnTickets.Size = new System.Drawing.Size(225, 41);
            this.pnTickets.TabIndex = 6;
            // 
            // btnTasks
            // 
            this.btnTasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.btnTasks.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnTasks.ForeColor = System.Drawing.Color.White;
            this.btnTasks.Image = ((System.Drawing.Image)(resources.GetObject("btnTasks.Image")));
            this.btnTasks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTasks.Location = new System.Drawing.Point(-4, -5);
            this.btnTasks.Name = "btnTasks";
            this.btnTasks.Size = new System.Drawing.Size(239, 50);
            this.btnTasks.TabIndex = 2;
            this.btnTasks.Text = "           Доступные задания";
            this.btnTasks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTasks.UseVisualStyleBackColor = false;
            this.btnTasks.Click += new System.EventHandler(this.btnTasks_Click);
            // 
            // pnExit
            // 
            this.pnExit.Controls.Add(this.btnExit);
            this.pnExit.Location = new System.Drawing.Point(3, 97);
            this.pnExit.Name = "pnExit";
            this.pnExit.Size = new System.Drawing.Size(225, 41);
            this.pnExit.TabIndex = 6;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(-4, -5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(239, 50);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "           Выйти";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnNews
            // 
            this.pnNews.Controls.Add(this.btnNews);
            this.pnNews.Location = new System.Drawing.Point(3, 132);
            this.pnNews.Name = "pnNews";
            this.pnNews.Size = new System.Drawing.Size(225, 41);
            this.pnNews.TabIndex = 5;
            // 
            // btnNews
            // 
            this.btnNews.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnNews.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnNews.ForeColor = System.Drawing.Color.White;
            this.btnNews.Image = ((System.Drawing.Image)(resources.GetObject("btnNews.Image")));
            this.btnNews.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNews.Location = new System.Drawing.Point(-14, -51);
            this.btnNews.Name = "btnNews";
            this.btnNews.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnNews.Size = new System.Drawing.Size(250, 144);
            this.btnNews.TabIndex = 2;
            this.btnNews.Text = "           Тестирование";
            this.btnNews.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNews.UseVisualStyleBackColor = false;
            this.btnNews.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // pnAbout
            // 
            this.pnAbout.Controls.Add(this.btnAbout);
            this.pnAbout.Location = new System.Drawing.Point(3, 179);
            this.pnAbout.Name = "pnAbout";
            this.pnAbout.Size = new System.Drawing.Size(225, 41);
            this.pnAbout.TabIndex = 7;
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(29)))));
            this.btnAbout.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.Image = ((System.Drawing.Image)(resources.GetObject("btnAbout.Image")));
            this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.Location = new System.Drawing.Point(-14, -51);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnAbout.Size = new System.Drawing.Size(250, 144);
            this.btnAbout.TabIndex = 2;
            this.btnAbout.Text = "           О приложении";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // menuTransition
            // 
            this.menuTransition.Interval = 8;
            this.menuTransition.Tick += new System.EventHandler(this.menuTransition_Tick);
            // 
            // sideBarTransition
            // 
            this.sideBarTransition.Interval = 10;
            this.sideBarTransition.Tick += new System.EventHandler(this.sideBarTransition_Tick);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 556);
            this.Controls.Add(this.SideBar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHam)).EndInit();
            this.SideBar.ResumeLayout(false);
            this.pnProfile.ResumeLayout(false);
            this.MenuContainer.ResumeLayout(false);
            this.pnMenu.ResumeLayout(false);
            this.pnTickets.ResumeLayout(false);
            this.pnExit.ResumeLayout(false);
            this.pnNews.ResumeLayout(false);
            this.pnAbout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnHam;
        private System.Windows.Forms.FlowLayoutPanel SideBar;
        private System.Windows.Forms.Panel pnProfile;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.FlowLayoutPanel MenuContainer;
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Button Menu;
        private System.Windows.Forms.Panel pnTickets;
        private System.Windows.Forms.Button btnTasks;
        private System.Windows.Forms.Panel pnExit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnNews;
        private System.Windows.Forms.Button btnNews;
        private System.Windows.Forms.Panel pnAbout;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Timer menuTransition;
        private System.Windows.Forms.Timer sideBarTransition;
    }
}