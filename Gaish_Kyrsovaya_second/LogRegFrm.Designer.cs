namespace Gaish_Kyrsovaya_second
{
    partial class LogRegFrm
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
            this.LabelLog = new System.Windows.Forms.Label();
            this.RegButton = new MaterialSkin.Controls.MaterialButton();
            this.PassTB = new MaterialSkin.Controls.MaterialTextBox();
            this.UserTB = new MaterialSkin.Controls.MaterialTextBox();
            this.LogButton = new MaterialSkin.Controls.MaterialButton();
            this.LabelReg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelLog
            // 
            this.LabelLog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelLog.AutoSize = true;
            this.LabelLog.Location = new System.Drawing.Point(166, 305);
            this.LabelLog.Name = "LabelLog";
            this.LabelLog.Size = new System.Drawing.Size(80, 26);
            this.LabelLog.TabIndex = 14;
            this.LabelLog.Text = "Есть аккаунт?\r\n     Войдите!";
            this.LabelLog.Visible = false;
            this.LabelLog.Click += new System.EventHandler(this.LabelLog_Click);
            // 
            // RegButton
            // 
            this.RegButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RegButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.RegButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.RegButton.Depth = 0;
            this.RegButton.HighEmphasis = true;
            this.RegButton.Icon = null;
            this.RegButton.Location = new System.Drawing.Point(111, 251);
            this.RegButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.RegButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.RegButton.Name = "RegButton";
            this.RegButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.RegButton.Size = new System.Drawing.Size(191, 36);
            this.RegButton.TabIndex = 13;
            this.RegButton.Text = "Зарегистрироваться";
            this.RegButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.RegButton.UseAccentColor = false;
            this.RegButton.UseVisualStyleBackColor = true;
            this.RegButton.Visible = false;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // PassTB
            // 
            this.PassTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PassTB.AnimateReadOnly = false;
            this.PassTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PassTB.Depth = 0;
            this.PassTB.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.PassTB.LeadingIcon = null;
            this.PassTB.Location = new System.Drawing.Point(78, 192);
            this.PassTB.MaxLength = 50;
            this.PassTB.MouseState = MaterialSkin.MouseState.OUT;
            this.PassTB.Multiline = false;
            this.PassTB.Name = "PassTB";
            this.PassTB.Size = new System.Drawing.Size(263, 50);
            this.PassTB.TabIndex = 12;
            this.PassTB.Text = "";
            this.PassTB.TrailingIcon = null;
            // 
            // UserTB
            // 
            this.UserTB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserTB.AnimateReadOnly = false;
            this.UserTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserTB.Depth = 0;
            this.UserTB.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.UserTB.LeadingIcon = null;
            this.UserTB.Location = new System.Drawing.Point(78, 109);
            this.UserTB.MaxLength = 50;
            this.UserTB.MouseState = MaterialSkin.MouseState.OUT;
            this.UserTB.Multiline = false;
            this.UserTB.Name = "UserTB";
            this.UserTB.Size = new System.Drawing.Size(263, 50);
            this.UserTB.TabIndex = 11;
            this.UserTB.Text = "";
            this.UserTB.TrailingIcon = null;
            // 
            // LogButton
            // 
            this.LogButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LogButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.LogButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.LogButton.Depth = 0;
            this.LogButton.HighEmphasis = true;
            this.LogButton.Icon = null;
            this.LogButton.Location = new System.Drawing.Point(169, 251);
            this.LogButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.LogButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.LogButton.Name = "LogButton";
            this.LogButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.LogButton.Size = new System.Drawing.Size(71, 36);
            this.LogButton.TabIndex = 15;
            this.LogButton.Text = "Войти";
            this.LogButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.LogButton.UseAccentColor = false;
            this.LogButton.UseVisualStyleBackColor = true;
            this.LogButton.Click += new System.EventHandler(this.LogButton_Click);
            // 
            // LabelReg
            // 
            this.LabelReg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelReg.AutoSize = true;
            this.LabelReg.Location = new System.Drawing.Point(159, 305);
            this.LabelReg.Name = "LabelReg";
            this.LabelReg.Size = new System.Drawing.Size(81, 26);
            this.LabelReg.TabIndex = 16;
            this.LabelReg.Text = "Нет аккаунта?\r\n    Создайте!";
            this.LabelReg.Click += new System.EventHandler(this.LabelReg_Click);
            // 
            // LogRegFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 382);
            this.Controls.Add(this.LabelReg);
            this.Controls.Add(this.RegButton);
            this.Controls.Add(this.LabelLog);
            this.Controls.Add(this.LogButton);
            this.Controls.Add(this.PassTB);
            this.Controls.Add(this.UserTB);
            this.Name = "LogRegFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация или Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelLog;
        private MaterialSkin.Controls.MaterialButton RegButton;
        private MaterialSkin.Controls.MaterialTextBox PassTB;
        private MaterialSkin.Controls.MaterialTextBox UserTB;
        private MaterialSkin.Controls.MaterialButton LogButton;
        private System.Windows.Forms.Label LabelReg;
    }
}