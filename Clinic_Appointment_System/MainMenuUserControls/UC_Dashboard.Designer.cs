namespace Clinic_Appointment_System.UserControls
{
    partial class UC_Dashboard
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
            this.lblCommingSoon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCommingSoon
            // 
            this.lblCommingSoon.AutoSize = true;
            this.lblCommingSoon.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommingSoon.ForeColor = System.Drawing.Color.White;
            this.lblCommingSoon.Location = new System.Drawing.Point(382, 268);
            this.lblCommingSoon.Name = "lblCommingSoon";
            this.lblCommingSoon.Size = new System.Drawing.Size(368, 55);
            this.lblCommingSoon.TabIndex = 2;
            this.lblCommingSoon.Text = "Comming Soon";
            // 
            // UC_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.Controls.Add(this.lblCommingSoon);
            this.Name = "UC_Dashboard";
            this.Size = new System.Drawing.Size(1133, 591);
            this.Load += new System.EventHandler(this.UC_Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCommingSoon;
    }
}
