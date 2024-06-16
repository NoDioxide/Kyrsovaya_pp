namespace Gaish_Kyrsovaya_second
{
    partial class Profile
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
            this.dungeonHeaderLabel1 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.PB = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.TBStatus = new MaterialSkin.Controls.MaterialTextBox();
            this.MBChange = new MaterialSkin.Controls.MaterialButton();
            this.TBUserName = new MaterialSkin.Controls.MaterialTextBox();
            this.MBUploadPicture = new MaterialSkin.Controls.MaterialButton();
            this.TBName = new MaterialSkin.Controls.MaterialTextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PB)).BeginInit();
            this.SuspendLayout();
            // 
            // dungeonHeaderLabel1
            // 
            this.dungeonHeaderLabel1.AutoSize = true;
            this.dungeonHeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.dungeonHeaderLabel1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.dungeonHeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.dungeonHeaderLabel1.Location = new System.Drawing.Point(440, 9);
            this.dungeonHeaderLabel1.Name = "dungeonHeaderLabel1";
            this.dungeonHeaderLabel1.Size = new System.Drawing.Size(140, 40);
            this.dungeonHeaderLabel1.TabIndex = 32;
            this.dungeonHeaderLabel1.Text = "Пройдено курсов:\r\n0/3\r\n";
            // 
            // PB
            // 
            this.PB.Location = new System.Drawing.Point(18, 174);
            this.PB.Name = "PB";
            this.PB.Size = new System.Drawing.Size(160, 140);
            this.PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB.TabIndex = 31;
            this.PB.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Enabled = false;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(13, 169);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(170, 149);
            this.button2.TabIndex = 30;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(215, 303);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(86, 19);
            this.materialLabel3.TabIndex = 25;
            this.materialLabel3.Text = "Ваш статус";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(441, 222);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(115, 19);
            this.materialLabel2.TabIndex = 24;
            this.materialLabel2.Text = "Ваша фамилия";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(254, 223);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(75, 19);
            this.materialLabel1.TabIndex = 23;
            this.materialLabel1.Text = "Ваше имя";
            // 
            // TBStatus
            // 
            this.TBStatus.AnimateReadOnly = false;
            this.TBStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBStatus.Depth = 0;
            this.TBStatus.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TBStatus.LeadingIcon = null;
            this.TBStatus.Location = new System.Drawing.Point(207, 250);
            this.TBStatus.MaxLength = 50;
            this.TBStatus.MouseState = MaterialSkin.MouseState.OUT;
            this.TBStatus.Multiline = false;
            this.TBStatus.Name = "TBStatus";
            this.TBStatus.Size = new System.Drawing.Size(382, 50);
            this.TBStatus.TabIndex = 22;
            this.TBStatus.Text = "";
            this.TBStatus.TrailingIcon = null;
            // 
            // MBChange
            // 
            this.MBChange.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MBChange.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.MBChange.Depth = 0;
            this.MBChange.HighEmphasis = true;
            this.MBChange.Icon = null;
            this.MBChange.Location = new System.Drawing.Point(318, 309);
            this.MBChange.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MBChange.MouseState = MaterialSkin.MouseState.HOVER;
            this.MBChange.Name = "MBChange";
            this.MBChange.NoAccentTextColor = System.Drawing.Color.Empty;
            this.MBChange.Size = new System.Drawing.Size(101, 36);
            this.MBChange.TabIndex = 21;
            this.MBChange.Text = "Изменить";
            this.MBChange.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.MBChange.UseAccentColor = false;
            this.MBChange.UseVisualStyleBackColor = true;
            this.MBChange.Click += new System.EventHandler(this.MBChangeInfo_Click);
            // 
            // TBUserName
            // 
            this.TBUserName.AnimateReadOnly = false;
            this.TBUserName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBUserName.Depth = 0;
            this.TBUserName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TBUserName.LeadingIcon = null;
            this.TBUserName.Location = new System.Drawing.Point(406, 169);
            this.TBUserName.MaxLength = 50;
            this.TBUserName.MouseState = MaterialSkin.MouseState.OUT;
            this.TBUserName.Multiline = false;
            this.TBUserName.Name = "TBUserName";
            this.TBUserName.Size = new System.Drawing.Size(183, 50);
            this.TBUserName.TabIndex = 20;
            this.TBUserName.Text = "";
            this.TBUserName.TrailingIcon = null;
            // 
            // MBUploadPicture
            // 
            this.MBUploadPicture.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MBUploadPicture.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.MBUploadPicture.Depth = 0;
            this.MBUploadPicture.HighEmphasis = true;
            this.MBUploadPicture.Icon = null;
            this.MBUploadPicture.Location = new System.Drawing.Point(43, 327);
            this.MBUploadPicture.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MBUploadPicture.MouseState = MaterialSkin.MouseState.HOVER;
            this.MBUploadPicture.Name = "MBUploadPicture";
            this.MBUploadPicture.NoAccentTextColor = System.Drawing.Color.Empty;
            this.MBUploadPicture.Size = new System.Drawing.Size(104, 36);
            this.MBUploadPicture.TabIndex = 19;
            this.MBUploadPicture.Text = "Загрузить";
            this.MBUploadPicture.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.MBUploadPicture.UseAccentColor = false;
            this.MBUploadPicture.UseVisualStyleBackColor = true;
            this.MBUploadPicture.Click += new System.EventHandler(this.MBUploadPicture_Click);
            // 
            // TBName
            // 
            this.TBName.AnimateReadOnly = false;
            this.TBName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBName.Depth = 0;
            this.TBName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.TBName.LeadingIcon = null;
            this.TBName.Location = new System.Drawing.Point(207, 170);
            this.TBName.MaxLength = 50;
            this.TBName.MouseState = MaterialSkin.MouseState.OUT;
            this.TBName.Multiline = false;
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(183, 50);
            this.TBName.TabIndex = 18;
            this.TBName.Text = "";
            this.TBName.TrailingIcon = null;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.IndianRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(610, 514);
            this.button1.TabIndex = 17;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 558);
            this.Controls.Add(this.dungeonHeaderLabel1);
            this.Controls.Add(this.PB);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.TBStatus);
            this.Controls.Add(this.MBChange);
            this.Controls.Add(this.TBUserName);
            this.Controls.Add(this.MBUploadPicture);
            this.Controls.Add(this.TBName);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Profile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.Profile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel1;
        private System.Windows.Forms.PictureBox PB;
        private System.Windows.Forms.Button button2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox TBStatus;
        private MaterialSkin.Controls.MaterialButton MBChange;
        private MaterialSkin.Controls.MaterialTextBox TBUserName;
        private MaterialSkin.Controls.MaterialButton MBUploadPicture;
        private MaterialSkin.Controls.MaterialTextBox TBName;
        private System.Windows.Forms.Button button1;
    }
}