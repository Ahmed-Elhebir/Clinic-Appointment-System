namespace Clinic_Appointment_System.Appointment
{
    partial class AddEditAppointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditAppointment));
            this.lblAddEditTitle = new System.Windows.Forms.Label();
            this.searchPatient = new Clinic_Appointment_System.Appointment.SearchControl();
            this.searchDoctor = new Clinic_Appointment_System.Appointment.SearchControl();
            this.lblPatientSearch = new System.Windows.Forms.Label();
            this.lblDoctorSearch = new System.Windows.Forms.Label();
            this.dtpAppointmentDate = new System.Windows.Forms.DateTimePicker();
            this.cbBusinessTime = new System.Windows.Forms.ComboBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblNotes = new System.Windows.Forms.Label();
            this.lblTimePicker = new System.Windows.Forms.Label();
            this.lblAppointmentDatePicker = new System.Windows.Forms.Label();
            this.pFullForm = new System.Windows.Forms.Panel();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSave = new System.Windows.Forms.Button();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.pFullForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAddEditTitle
            // 
            this.lblAddEditTitle.AutoSize = true;
            this.lblAddEditTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddEditTitle.ForeColor = System.Drawing.Color.LightGray;
            this.lblAddEditTitle.Location = new System.Drawing.Point(15, 12);
            this.lblAddEditTitle.Name = "lblAddEditTitle";
            this.lblAddEditTitle.Size = new System.Drawing.Size(220, 24);
            this.lblAddEditTitle.TabIndex = 54;
            this.lblAddEditTitle.Text = "Add New Appointment";
            // 
            // searchPatient
            // 
            this.searchPatient.Location = new System.Drawing.Point(12, 75);
            this.searchPatient.Name = "searchPatient";
            this.searchPatient.Size = new System.Drawing.Size(531, 129);
            this.searchPatient.TabIndex = 56;
            this.searchPatient.OnSearch += new System.EventHandler<Clinic_Appointment_System.Appointment.SearchControl.SearchEventArgs>(this.SearchPatient_OnSearch);
            this.searchPatient.Validating += new System.ComponentModel.CancelEventHandler(this.SearchPatient_Validating);
            // 
            // searchDoctor
            // 
            this.searchDoctor.Location = new System.Drawing.Point(12, 232);
            this.searchDoctor.Name = "searchDoctor";
            this.searchDoctor.Size = new System.Drawing.Size(531, 129);
            this.searchDoctor.TabIndex = 57;
            this.searchDoctor.OnSearch += new System.EventHandler<Clinic_Appointment_System.Appointment.SearchControl.SearchEventArgs>(this.SearchDoctor_OnSearch);
            this.searchDoctor.Validating += new System.ComponentModel.CancelEventHandler(this.searchDoctor_Validating);
            // 
            // lblPatientSearch
            // 
            this.lblPatientSearch.AutoSize = true;
            this.lblPatientSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatientSearch.ForeColor = System.Drawing.Color.LightGray;
            this.lblPatientSearch.Location = new System.Drawing.Point(12, 56);
            this.lblPatientSearch.Name = "lblPatientSearch";
            this.lblPatientSearch.Size = new System.Drawing.Size(95, 13);
            this.lblPatientSearch.TabIndex = 58;
            this.lblPatientSearch.Text = "Search Patient:";
            // 
            // lblDoctorSearch
            // 
            this.lblDoctorSearch.AutoSize = true;
            this.lblDoctorSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoctorSearch.ForeColor = System.Drawing.Color.LightGray;
            this.lblDoctorSearch.Location = new System.Drawing.Point(12, 216);
            this.lblDoctorSearch.Name = "lblDoctorSearch";
            this.lblDoctorSearch.Size = new System.Drawing.Size(93, 13);
            this.lblDoctorSearch.TabIndex = 59;
            this.lblDoctorSearch.Text = "Search Doctor:";
            // 
            // dtpAppointmentDate
            // 
            this.dtpAppointmentDate.Location = new System.Drawing.Point(172, 374);
            this.dtpAppointmentDate.Name = "dtpAppointmentDate";
            this.dtpAppointmentDate.Size = new System.Drawing.Size(200, 20);
            this.dtpAppointmentDate.TabIndex = 60;
            this.dtpAppointmentDate.Validating += new System.ComponentModel.CancelEventHandler(this.dtpAppointmentDate_Validating);
            // 
            // cbBusinessTime
            // 
            this.cbBusinessTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBusinessTime.FormattingEnabled = true;
            this.cbBusinessTime.Location = new System.Drawing.Point(100, 404);
            this.cbBusinessTime.Name = "cbBusinessTime";
            this.cbBusinessTime.Size = new System.Drawing.Size(95, 21);
            this.cbBusinessTime.TabIndex = 61;
            this.cbBusinessTime.Validating += new System.ComponentModel.CancelEventHandler(this.cbBusinessTime_Validating);
            // 
            // txtNotes
            // 
            this.txtNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNotes.Location = new System.Drawing.Point(15, 458);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(524, 74);
            this.txtNotes.TabIndex = 62;
            // 
            // btnCancel
            // 
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.LightGray;
            this.btnCancel.Image = global::Clinic_Appointment_System.Properties.Resources.Cancel_White_20;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(283, 559);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(255, 32);
            this.btnCancel.TabIndex = 64;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblNotes
            // 
            this.lblNotes.AutoSize = true;
            this.lblNotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNotes.ForeColor = System.Drawing.Color.LightGray;
            this.lblNotes.Location = new System.Drawing.Point(16, 435);
            this.lblNotes.Name = "lblNotes";
            this.lblNotes.Size = new System.Drawing.Size(44, 13);
            this.lblNotes.TabIndex = 65;
            this.lblNotes.Text = "Notes:";
            // 
            // lblTimePicker
            // 
            this.lblTimePicker.AutoSize = true;
            this.lblTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimePicker.ForeColor = System.Drawing.Color.LightGray;
            this.lblTimePicker.Location = new System.Drawing.Point(15, 408);
            this.lblTimePicker.Name = "lblTimePicker";
            this.lblTimePicker.Size = new System.Drawing.Size(67, 13);
            this.lblTimePicker.TabIndex = 66;
            this.lblTimePicker.Text = "Pick Time:";
            // 
            // lblAppointmentDatePicker
            // 
            this.lblAppointmentDatePicker.AutoSize = true;
            this.lblAppointmentDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppointmentDatePicker.ForeColor = System.Drawing.Color.LightGray;
            this.lblAppointmentDatePicker.Location = new System.Drawing.Point(15, 378);
            this.lblAppointmentDatePicker.Name = "lblAppointmentDatePicker";
            this.lblAppointmentDatePicker.Size = new System.Drawing.Size(141, 13);
            this.lblAppointmentDatePicker.TabIndex = 67;
            this.lblAppointmentDatePicker.Text = "Pick Appointment Date:";
            // 
            // pFullForm
            // 
            this.pFullForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pFullForm.Controls.Add(this.btnCancel);
            this.pFullForm.Location = new System.Drawing.Point(0, 0);
            this.pFullForm.Name = "pFullForm";
            this.pFullForm.Size = new System.Drawing.Size(553, 635);
            this.pFullForm.TabIndex = 68;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightGray;
            this.btnSave.Image = global::Clinic_Appointment_System.Properties.Resources.Save_Black_20;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(15, 560);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(244, 32);
            this.btnSave.TabIndex = 63;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pbClose
            // 
            this.pbClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
            this.pbClose.Location = new System.Drawing.Point(506, 12);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(25, 25);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClose.TabIndex = 55;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // AddEditAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(553, 635);
            this.Controls.Add(this.lblAppointmentDatePicker);
            this.Controls.Add(this.lblTimePicker);
            this.Controls.Add(this.lblNotes);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.cbBusinessTime);
            this.Controls.Add(this.dtpAppointmentDate);
            this.Controls.Add(this.lblDoctorSearch);
            this.Controls.Add(this.lblPatientSearch);
            this.Controls.Add(this.searchDoctor);
            this.Controls.Add(this.searchPatient);
            this.Controls.Add(this.pbClose);
            this.Controls.Add(this.lblAddEditTitle);
            this.Controls.Add(this.pFullForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddEditAppointment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add/Edit Appointment";
            this.Load += new System.EventHandler(this.AddEditAppointment_Load);
            this.pFullForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.Label lblAddEditTitle;
        private SearchControl searchPatient;
        private SearchControl searchDoctor;
        private System.Windows.Forms.Label lblPatientSearch;
        private System.Windows.Forms.Label lblDoctorSearch;
        private System.Windows.Forms.DateTimePicker dtpAppointmentDate;
        private System.Windows.Forms.ComboBox cbBusinessTime;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblNotes;
        private System.Windows.Forms.Label lblTimePicker;
        private System.Windows.Forms.Label lblAppointmentDatePicker;
        private System.Windows.Forms.Panel pFullForm;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}