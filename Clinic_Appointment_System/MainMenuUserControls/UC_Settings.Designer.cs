namespace Clinic_Appointment_System.UserControls
{
    partial class UC_Settings
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pAppearance = new System.Windows.Forms.Panel();
            this.btnDarkMode = new System.Windows.Forms.Button();
            this.btnLightMode = new System.Windows.Forms.Button();
            this.lblTheme = new System.Windows.Forms.Label();
            this.pbAppearance = new System.Windows.Forms.PictureBox();
            this.lblAppearanceTitle = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pAppearance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAppearance)).BeginInit();
            this.SuspendLayout();
            // 
            // pAppearance
            // 
            this.pAppearance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pAppearance.Controls.Add(this.btnDarkMode);
            this.pAppearance.Controls.Add(this.btnLightMode);
            this.pAppearance.Controls.Add(this.lblTheme);
            this.pAppearance.Controls.Add(this.pbAppearance);
            this.pAppearance.Controls.Add(this.lblAppearanceTitle);
            this.pAppearance.Location = new System.Drawing.Point(16, 113);
            this.pAppearance.Name = "pAppearance";
            this.pAppearance.Size = new System.Drawing.Size(189, 161);
            this.pAppearance.TabIndex = 4;
            // 
            // btnDarkMode
            // 
            this.btnDarkMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btnDarkMode.FlatAppearance.BorderSize = 0;
            this.btnDarkMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDarkMode.ForeColor = System.Drawing.Color.White;
            this.btnDarkMode.Image = global::Clinic_Appointment_System.Properties.Resources.Dark_Mode_White_20;
            this.btnDarkMode.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnDarkMode.Location = new System.Drawing.Point(100, 95);
            this.btnDarkMode.Name = "btnDarkMode";
            this.btnDarkMode.Size = new System.Drawing.Size(72, 49);
            this.btnDarkMode.TabIndex = 4;
            this.btnDarkMode.Text = "Dark";
            this.btnDarkMode.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDarkMode.UseVisualStyleBackColor = false;
            this.btnDarkMode.Click += new System.EventHandler(this.btnDarkMode_Click);
            this.btnDarkMode.MouseEnter += new System.EventHandler(this.btnDarkMode_MouseEnter);
            this.btnDarkMode.MouseLeave += new System.EventHandler(this.btnDarkMode_MouseLeave);
            // 
            // btnLightMode
            // 
            this.btnLightMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btnLightMode.FlatAppearance.BorderSize = 0;
            this.btnLightMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLightMode.ForeColor = System.Drawing.Color.White;
            this.btnLightMode.Image = global::Clinic_Appointment_System.Properties.Resources.Light_Mode_White_20;
            this.btnLightMode.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnLightMode.Location = new System.Drawing.Point(10, 95);
            this.btnLightMode.Name = "btnLightMode";
            this.btnLightMode.Size = new System.Drawing.Size(72, 49);
            this.btnLightMode.TabIndex = 3;
            this.btnLightMode.Text = "Light";
            this.btnLightMode.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLightMode.UseVisualStyleBackColor = false;
            this.btnLightMode.Click += new System.EventHandler(this.btnLightMode_Click);
            this.btnLightMode.MouseEnter += new System.EventHandler(this.btnLightMode_MouseEnter);
            this.btnLightMode.MouseLeave += new System.EventHandler(this.btnLightMode_MouseLeave);
            // 
            // lblTheme
            // 
            this.lblTheme.AutoSize = true;
            this.lblTheme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTheme.ForeColor = System.Drawing.Color.White;
            this.lblTheme.Location = new System.Drawing.Point(10, 61);
            this.lblTheme.Name = "lblTheme";
            this.lblTheme.Size = new System.Drawing.Size(55, 16);
            this.lblTheme.TabIndex = 2;
            this.lblTheme.Text = "Theme";
            // 
            // pbAppearance
            // 
            this.pbAppearance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbAppearance.Image = global::Clinic_Appointment_System.Properties.Resources.Appearance_White_20;
            this.pbAppearance.Location = new System.Drawing.Point(10, 10);
            this.pbAppearance.Name = "pbAppearance";
            this.pbAppearance.Size = new System.Drawing.Size(20, 20);
            this.pbAppearance.TabIndex = 1;
            this.pbAppearance.TabStop = false;
            // 
            // lblAppearanceTitle
            // 
            this.lblAppearanceTitle.AutoSize = true;
            this.lblAppearanceTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppearanceTitle.ForeColor = System.Drawing.Color.White;
            this.lblAppearanceTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAppearanceTitle.Location = new System.Drawing.Point(46, 12);
            this.lblAppearanceTitle.Name = "lblAppearanceTitle";
            this.lblAppearanceTitle.Size = new System.Drawing.Size(92, 16);
            this.lblAppearanceTitle.TabIndex = 0;
            this.lblAppearanceTitle.Text = "Appearance";
            this.lblAppearanceTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.LightGray;
            this.lblDescription.Location = new System.Drawing.Point(15, 56);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(283, 16);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Customize your clinic management experience";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(15, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(121, 31);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Settings";
            // 
            // UC_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.pAppearance);
            this.Controls.Add(this.lblTitle);
            this.Name = "UC_Settings";
            this.Size = new System.Drawing.Size(1133, 591);
            this.Load += new System.EventHandler(this.UC_Settings_Load);
            this.pAppearance.ResumeLayout(false);
            this.pAppearance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAppearance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pAppearance;
        private System.Windows.Forms.Label lblTheme;
        private System.Windows.Forms.PictureBox pbAppearance;
        private System.Windows.Forms.Label lblAppearanceTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnDarkMode;
        private System.Windows.Forms.Button btnLightMode;
    }
}
