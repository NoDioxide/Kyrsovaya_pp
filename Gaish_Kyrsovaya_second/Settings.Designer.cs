namespace Gaish_Kyrsovaya_second
{
    partial class Settings
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
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCheckbox17 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox16 = new MaterialSkin.Controls.MaterialCheckbox();
            this.CBCorrect5 = new MaterialSkin.Controls.MaterialCheckbox();
            this.materialCheckbox15 = new MaterialSkin.Controls.MaterialCheckbox();
            this.SuspendLayout();
            // 
            // materialLabel6
            // 
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(21, 9);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(774, 44);
            this.materialLabel6.TabIndex = 94;
            this.materialLabel6.Text = "Вопрос 5:\r\nКакой из следующих символов используется для обозначения ввода/вывода " +
    "данных в блок-схеме?";
            this.materialLabel6.Visible = false;
            // 
            // materialCheckbox17
            // 
            this.materialCheckbox17.AutoSize = true;
            this.materialCheckbox17.Depth = 0;
            this.materialCheckbox17.Font = new System.Drawing.Font("Microsoft Sans Serif", 3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.materialCheckbox17.Location = new System.Drawing.Point(24, 168);
            this.materialCheckbox17.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox17.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox17.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox17.Name = "materialCheckbox17";
            this.materialCheckbox17.ReadOnly = false;
            this.materialCheckbox17.Ripple = true;
            this.materialCheckbox17.Size = new System.Drawing.Size(73, 37);
            this.materialCheckbox17.TabIndex = 89;
            this.materialCheckbox17.Text = "Круг.";
            this.materialCheckbox17.UseVisualStyleBackColor = true;
            this.materialCheckbox17.Visible = false;
            // 
            // materialCheckbox16
            // 
            this.materialCheckbox16.AutoSize = true;
            this.materialCheckbox16.Depth = 0;
            this.materialCheckbox16.Font = new System.Drawing.Font("Microsoft Sans Serif", 3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.materialCheckbox16.Location = new System.Drawing.Point(24, 131);
            this.materialCheckbox16.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox16.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox16.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox16.Name = "materialCheckbox16";
            this.materialCheckbox16.ReadOnly = false;
            this.materialCheckbox16.Ripple = true;
            this.materialCheckbox16.Size = new System.Drawing.Size(158, 37);
            this.materialCheckbox16.TabIndex = 88;
            this.materialCheckbox16.Text = "Прямоугольник.";
            this.materialCheckbox16.UseVisualStyleBackColor = true;
            this.materialCheckbox16.Visible = false;
            // 
            // CBCorrect5
            // 
            this.CBCorrect5.AutoSize = true;
            this.CBCorrect5.Depth = 0;
            this.CBCorrect5.Font = new System.Drawing.Font("Microsoft Sans Serif", 3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBCorrect5.Location = new System.Drawing.Point(24, 94);
            this.CBCorrect5.Margin = new System.Windows.Forms.Padding(0);
            this.CBCorrect5.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CBCorrect5.MouseState = MaterialSkin.MouseState.HOVER;
            this.CBCorrect5.Name = "CBCorrect5";
            this.CBCorrect5.ReadOnly = false;
            this.CBCorrect5.Ripple = true;
            this.CBCorrect5.Size = new System.Drawing.Size(77, 37);
            this.CBCorrect5.TabIndex = 87;
            this.CBCorrect5.Text = "Овал.";
            this.CBCorrect5.UseVisualStyleBackColor = true;
            this.CBCorrect5.Visible = false;
            // 
            // materialCheckbox15
            // 
            this.materialCheckbox15.AutoSize = true;
            this.materialCheckbox15.Depth = 0;
            this.materialCheckbox15.Font = new System.Drawing.Font("Microsoft Sans Serif", 3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.materialCheckbox15.Location = new System.Drawing.Point(24, 57);
            this.materialCheckbox15.Margin = new System.Windows.Forms.Padding(0);
            this.materialCheckbox15.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialCheckbox15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCheckbox15.Name = "materialCheckbox15";
            this.materialCheckbox15.ReadOnly = false;
            this.materialCheckbox15.Ripple = true;
            this.materialCheckbox15.Size = new System.Drawing.Size(79, 37);
            this.materialCheckbox15.TabIndex = 86;
            this.materialCheckbox15.Text = "Ромб.";
            this.materialCheckbox15.UseVisualStyleBackColor = true;
            this.materialCheckbox15.Visible = false;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 558);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.materialCheckbox17);
            this.Controls.Add(this.materialCheckbox16);
            this.Controls.Add(this.CBCorrect5);
            this.Controls.Add(this.materialCheckbox15);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox17;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox16;
        private MaterialSkin.Controls.MaterialCheckbox CBCorrect5;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckbox15;
    }
}