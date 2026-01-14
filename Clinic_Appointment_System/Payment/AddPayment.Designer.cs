namespace Clinic_Appointment_System.Payment
{
    partial class AddPayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPayment));
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.lblAddEditTitle = new System.Windows.Forms.Label();
            this.pAppointmentDetails = new System.Windows.Forms.Panel();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblDoctorName = new System.Windows.Forms.Label();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.lblAppointmentID = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.lblPatient = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblAppointmentDetails = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.lblPaymentInfo = new System.Windows.Forms.Label();
            this.pPaymentInfo = new System.Windows.Forms.Panel();
            this.cbPaymentMethod = new System.Windows.Forms.ComboBox();
            this.lblPaymentMethod = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.pFullForm = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.pAppointmentDetails.SuspendLayout();
            this.pPaymentInfo.SuspendLayout();
            this.pFullForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbClose
            // 
            this.pbClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
            this.pbClose.Location = new System.Drawing.Point(503, 9);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(25, 25);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClose.TabIndex = 57;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // lblAddEditTitle
            // 
            this.lblAddEditTitle.AutoSize = true;
            this.lblAddEditTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddEditTitle.ForeColor = System.Drawing.Color.LightGray;
            this.lblAddEditTitle.Location = new System.Drawing.Point(12, 10);
            this.lblAddEditTitle.Name = "lblAddEditTitle";
            this.lblAddEditTitle.Size = new System.Drawing.Size(182, 24);
            this.lblAddEditTitle.TabIndex = 56;
            this.lblAddEditTitle.Text = "Add New Payment";
            // 
            // pAppointmentDetails
            // 
            this.pAppointmentDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pAppointmentDetails.Controls.Add(this.lblDateTime);
            this.pAppointmentDetails.Controls.Add(this.lblDoctorName);
            this.pAppointmentDetails.Controls.Add(this.lblPatientName);
            this.pAppointmentDetails.Controls.Add(this.lblAppointmentID);
            this.pAppointmentDetails.Controls.Add(this.lblDate);
            this.pAppointmentDetails.Controls.Add(this.lblDoctor);
            this.pAppointmentDetails.Controls.Add(this.lblPatient);
            this.pAppointmentDetails.Controls.Add(this.lblID);
            this.pAppointmentDetails.Location = new System.Drawing.Point(12, 105);
            this.pAppointmentDetails.Name = "pAppointmentDetails";
            this.pAppointmentDetails.Size = new System.Drawing.Size(521, 124);
            this.pAppointmentDetails.TabIndex = 58;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.Color.LightGray;
            this.lblDateTime.Location = new System.Drawing.Point(95, 90);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(28, 15);
            this.lblDateTime.TabIndex = 67;
            this.lblDateTime.Text = "???";
            // 
            // lblDoctorName
            // 
            this.lblDoctorName.AutoSize = true;
            this.lblDoctorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorName.ForeColor = System.Drawing.Color.LightGray;
            this.lblDoctorName.Location = new System.Drawing.Point(95, 63);
            this.lblDoctorName.Name = "lblDoctorName";
            this.lblDoctorName.Size = new System.Drawing.Size(28, 15);
            this.lblDoctorName.TabIndex = 66;
            this.lblDoctorName.Text = "???";
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientName.ForeColor = System.Drawing.Color.LightGray;
            this.lblPatientName.Location = new System.Drawing.Point(95, 36);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(28, 15);
            this.lblPatientName.TabIndex = 65;
            this.lblPatientName.Text = "???";
            // 
            // lblAppointmentID
            // 
            this.lblAppointmentID.AutoSize = true;
            this.lblAppointmentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentID.ForeColor = System.Drawing.Color.LightGray;
            this.lblAppointmentID.Location = new System.Drawing.Point(95, 11);
            this.lblAppointmentID.Name = "lblAppointmentID";
            this.lblAppointmentID.Size = new System.Drawing.Size(28, 15);
            this.lblAppointmentID.TabIndex = 64;
            this.lblAppointmentID.Text = "???";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.LightGray;
            this.lblDate.Location = new System.Drawing.Point(10, 90);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(41, 15);
            this.lblDate.TabIndex = 63;
            this.lblDate.Text = "Date:";
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctor.ForeColor = System.Drawing.Color.LightGray;
            this.lblDoctor.Location = new System.Drawing.Point(10, 63);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(53, 15);
            this.lblDoctor.TabIndex = 62;
            this.lblDoctor.Text = "Doctor:";
            // 
            // lblPatient
            // 
            this.lblPatient.AutoSize = true;
            this.lblPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatient.ForeColor = System.Drawing.Color.LightGray;
            this.lblPatient.Location = new System.Drawing.Point(10, 36);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(56, 15);
            this.lblPatient.TabIndex = 61;
            this.lblPatient.Text = "Patient:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.LightGray;
            this.lblID.Location = new System.Drawing.Point(10, 11);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(25, 15);
            this.lblID.TabIndex = 60;
            this.lblID.Text = "ID:";
            // 
            // lblAppointmentDetails
            // 
            this.lblAppointmentDetails.AutoSize = true;
            this.lblAppointmentDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentDetails.ForeColor = System.Drawing.Color.LightGray;
            this.lblAppointmentDetails.Location = new System.Drawing.Point(12, 77);
            this.lblAppointmentDetails.Name = "lblAppointmentDetails";
            this.lblAppointmentDetails.Size = new System.Drawing.Size(163, 18);
            this.lblAppointmentDetails.TabIndex = 59;
            this.lblAppointmentDetails.Text = "Appointment Details:";
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.LightGray;
            this.btnCancel.Image = global::Clinic_Appointment_System.Properties.Resources.Cancel_White_20;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(294, 427);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(238, 28);
            this.btnCancel.TabIndex = 66;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.LightGray;
            this.btnPay.Image = global::Clinic_Appointment_System.Properties.Resources.Payment_Black_20;
            this.btnPay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPay.Location = new System.Drawing.Point(11, 427);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(238, 28);
            this.btnPay.TabIndex = 65;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // lblPaymentInfo
            // 
            this.lblPaymentInfo.AutoSize = true;
            this.lblPaymentInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentInfo.ForeColor = System.Drawing.Color.LightGray;
            this.lblPaymentInfo.Location = new System.Drawing.Point(12, 257);
            this.lblPaymentInfo.Name = "lblPaymentInfo";
            this.lblPaymentInfo.Size = new System.Drawing.Size(168, 18);
            this.lblPaymentInfo.TabIndex = 67;
            this.lblPaymentInfo.Text = "Payment Information:";
            // 
            // pPaymentInfo
            // 
            this.pPaymentInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pPaymentInfo.Controls.Add(this.cbPaymentMethod);
            this.pPaymentInfo.Controls.Add(this.lblPaymentMethod);
            this.pPaymentInfo.Controls.Add(this.txtAmount);
            this.pPaymentInfo.Controls.Add(this.lblAmount);
            this.pPaymentInfo.Location = new System.Drawing.Point(12, 285);
            this.pPaymentInfo.Name = "pPaymentInfo";
            this.pPaymentInfo.Size = new System.Drawing.Size(521, 88);
            this.pPaymentInfo.TabIndex = 72;
            // 
            // cbPaymentMethod
            // 
            this.cbPaymentMethod.BackColor = System.Drawing.SystemColors.Window;
            this.cbPaymentMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPaymentMethod.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbPaymentMethod.FormattingEnabled = true;
            this.cbPaymentMethod.Location = new System.Drawing.Point(167, 46);
            this.cbPaymentMethod.Name = "cbPaymentMethod";
            this.cbPaymentMethod.Size = new System.Drawing.Size(121, 21);
            this.cbPaymentMethod.TabIndex = 75;
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.AutoSize = true;
            this.lblPaymentMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentMethod.ForeColor = System.Drawing.Color.LightGray;
            this.lblPaymentMethod.Location = new System.Drawing.Point(10, 52);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(118, 15);
            this.lblPaymentMethod.TabIndex = 74;
            this.lblPaymentMethod.Text = "Payment Method:";
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.SystemColors.Window;
            this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmount.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtAmount.Location = new System.Drawing.Point(167, 14);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(121, 20);
            this.txtAmount.TabIndex = 73;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.Color.LightGray;
            this.lblAmount.Location = new System.Drawing.Point(10, 19);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(100, 15);
            this.lblAmount.TabIndex = 72;
            this.lblAmount.Text = "Amount (SAR):";
            // 
            // pFullForm
            // 
            this.pFullForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pFullForm.Controls.Add(this.btnCancel);
            this.pFullForm.Controls.Add(this.btnPay);
            this.pFullForm.Location = new System.Drawing.Point(0, 0);
            this.pFullForm.Name = "pFullForm";
            this.pFullForm.Size = new System.Drawing.Size(545, 472);
            this.pFullForm.TabIndex = 73;
            // 
            // AddPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(545, 472);
            this.Controls.Add(this.pPaymentInfo);
            this.Controls.Add(this.lblPaymentInfo);
            this.Controls.Add(this.lblAppointmentDetails);
            this.Controls.Add(this.pAppointmentDetails);
            this.Controls.Add(this.pbClose);
            this.Controls.Add(this.lblAddEditTitle);
            this.Controls.Add(this.pFullForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddPayment";
            this.Load += new System.EventHandler(this.AddPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.pAppointmentDetails.ResumeLayout(false);
            this.pAppointmentDetails.PerformLayout();
            this.pPaymentInfo.ResumeLayout(false);
            this.pPaymentInfo.PerformLayout();
            this.pFullForm.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.Label lblAddEditTitle;
        private System.Windows.Forms.Panel pAppointmentDetails;
        private System.Windows.Forms.Label lblAppointmentDetails;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lblDoctorName;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.Label lblAppointmentID;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.Label lblPatient;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label lblPaymentInfo;
        private System.Windows.Forms.Panel pPaymentInfo;
        private System.Windows.Forms.ComboBox cbPaymentMethod;
        private System.Windows.Forms.Label lblPaymentMethod;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Panel pFullForm;
    }
}