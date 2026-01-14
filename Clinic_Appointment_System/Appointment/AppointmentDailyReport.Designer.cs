namespace Clinic_Appointment_System.Appointment
{
    partial class AppointmentDailyReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppointmentDailyReport));
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.dgvAppointmentReportList = new System.Windows.Forms.DataGridView();
            this.lblRecord = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.dtpReportDate = new System.Windows.Forms.DateTimePicker();
            this.lblTodayAppointment = new System.Windows.Forms.Label();
            this.pbTodayAppointment = new System.Windows.Forms.PictureBox();
            this.lblTodaysAppointments = new System.Windows.Forms.Label();
            this.pTodayAppointment = new System.Windows.Forms.Panel();
            this.lblCompleted = new System.Windows.Forms.Label();
            this.pbCompleted = new System.Windows.Forms.PictureBox();
            this.lblCompletedAppointments = new System.Windows.Forms.Label();
            this.pCompleted = new System.Windows.Forms.Panel();
            this.lblCancelled = new System.Windows.Forms.Label();
            this.pbCancelled = new System.Windows.Forms.PictureBox();
            this.lblCancelledAppointments = new System.Windows.Forms.Label();
            this.pCancelled = new System.Windows.Forms.Panel();
            this.lblFilterBy = new System.Windows.Forms.Label();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.pFullForm = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointmentReportList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTodayAppointment)).BeginInit();
            this.pTodayAppointment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCompleted)).BeginInit();
            this.pCompleted.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelled)).BeginInit();
            this.pCancelled.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.BackColor = System.Drawing.Color.LightGray;
            this.btnGenerateReport.Image = global::Clinic_Appointment_System.Properties.Resources.Report_Black_20;
            this.btnGenerateReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerateReport.Location = new System.Drawing.Point(568, 71);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(253, 29);
            this.btnGenerateReport.TabIndex = 13;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = false;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // dgvAppointmentReportList
            // 
            this.dgvAppointmentReportList.AllowUserToAddRows = false;
            this.dgvAppointmentReportList.AllowUserToDeleteRows = false;
            this.dgvAppointmentReportList.AllowUserToResizeColumns = false;
            this.dgvAppointmentReportList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.LightGray;
            this.dgvAppointmentReportList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAppointmentReportList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAppointmentReportList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.dgvAppointmentReportList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAppointmentReportList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvAppointmentReportList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAppointmentReportList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAppointmentReportList.ColumnHeadersHeight = 28;
            this.dgvAppointmentReportList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAppointmentReportList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAppointmentReportList.EnableHeadersVisualStyles = false;
            this.dgvAppointmentReportList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.dgvAppointmentReportList.Location = new System.Drawing.Point(12, 274);
            this.dgvAppointmentReportList.MultiSelect = false;
            this.dgvAppointmentReportList.Name = "dgvAppointmentReportList";
            this.dgvAppointmentReportList.ReadOnly = true;
            this.dgvAppointmentReportList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvAppointmentReportList.RowHeadersVisible = false;
            this.dgvAppointmentReportList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.LightGray;
            this.dgvAppointmentReportList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAppointmentReportList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAppointmentReportList.Size = new System.Drawing.Size(809, 250);
            this.dgvAppointmentReportList.TabIndex = 12;
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.ForeColor = System.Drawing.Color.LightGray;
            this.lblRecord.Location = new System.Drawing.Point(12, 247);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(25, 13);
            this.lblRecord.TabIndex = 11;
            this.lblRecord.Text = "???";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(323, 29);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Daily Appointments Report";
            // 
            // dtpReportDate
            // 
            this.dtpReportDate.Location = new System.Drawing.Point(126, 75);
            this.dtpReportDate.Name = "dtpReportDate";
            this.dtpReportDate.Size = new System.Drawing.Size(200, 20);
            this.dtpReportDate.TabIndex = 14;
            // 
            // lblTodayAppointment
            // 
            this.lblTodayAppointment.AutoSize = true;
            this.lblTodayAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayAppointment.ForeColor = System.Drawing.Color.White;
            this.lblTodayAppointment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTodayAppointment.Location = new System.Drawing.Point(46, 12);
            this.lblTodayAppointment.Name = "lblTodayAppointment";
            this.lblTodayAppointment.Size = new System.Drawing.Size(162, 16);
            this.lblTodayAppointment.TabIndex = 0;
            this.lblTodayAppointment.Text = "Today\'s Appointments";
            this.lblTodayAppointment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbTodayAppointment
            // 
            this.pbTodayAppointment.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbTodayAppointment.Image = ((System.Drawing.Image)(resources.GetObject("pbTodayAppointment.Image")));
            this.pbTodayAppointment.Location = new System.Drawing.Point(10, 10);
            this.pbTodayAppointment.Name = "pbTodayAppointment";
            this.pbTodayAppointment.Size = new System.Drawing.Size(20, 20);
            this.pbTodayAppointment.TabIndex = 1;
            this.pbTodayAppointment.TabStop = false;
            // 
            // lblTodaysAppointments
            // 
            this.lblTodaysAppointments.AutoSize = true;
            this.lblTodaysAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodaysAppointments.ForeColor = System.Drawing.Color.White;
            this.lblTodaysAppointments.Location = new System.Drawing.Point(10, 56);
            this.lblTodaysAppointments.Name = "lblTodaysAppointments";
            this.lblTodaysAppointments.Size = new System.Drawing.Size(25, 25);
            this.lblTodaysAppointments.TabIndex = 2;
            this.lblTodaysAppointments.Text = "0";
            // 
            // pTodayAppointment
            // 
            this.pTodayAppointment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pTodayAppointment.Controls.Add(this.lblTodaysAppointments);
            this.pTodayAppointment.Controls.Add(this.pbTodayAppointment);
            this.pTodayAppointment.Controls.Add(this.lblTodayAppointment);
            this.pTodayAppointment.Location = new System.Drawing.Point(12, 121);
            this.pTodayAppointment.Name = "pTodayAppointment";
            this.pTodayAppointment.Size = new System.Drawing.Size(253, 95);
            this.pTodayAppointment.TabIndex = 15;
            // 
            // lblCompleted
            // 
            this.lblCompleted.AutoSize = true;
            this.lblCompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompleted.ForeColor = System.Drawing.Color.White;
            this.lblCompleted.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCompleted.Location = new System.Drawing.Point(46, 12);
            this.lblCompleted.Name = "lblCompleted";
            this.lblCompleted.Size = new System.Drawing.Size(82, 16);
            this.lblCompleted.TabIndex = 0;
            this.lblCompleted.Text = "Completed";
            this.lblCompleted.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbCompleted
            // 
            this.pbCompleted.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbCompleted.Image = ((System.Drawing.Image)(resources.GetObject("pbCompleted.Image")));
            this.pbCompleted.Location = new System.Drawing.Point(10, 10);
            this.pbCompleted.Name = "pbCompleted";
            this.pbCompleted.Size = new System.Drawing.Size(20, 20);
            this.pbCompleted.TabIndex = 1;
            this.pbCompleted.TabStop = false;
            // 
            // lblCompletedAppointments
            // 
            this.lblCompletedAppointments.AutoSize = true;
            this.lblCompletedAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompletedAppointments.ForeColor = System.Drawing.Color.White;
            this.lblCompletedAppointments.Location = new System.Drawing.Point(10, 56);
            this.lblCompletedAppointments.Name = "lblCompletedAppointments";
            this.lblCompletedAppointments.Size = new System.Drawing.Size(25, 25);
            this.lblCompletedAppointments.TabIndex = 2;
            this.lblCompletedAppointments.Text = "0";
            // 
            // pCompleted
            // 
            this.pCompleted.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pCompleted.Controls.Add(this.lblCompletedAppointments);
            this.pCompleted.Controls.Add(this.pbCompleted);
            this.pCompleted.Controls.Add(this.lblCompleted);
            this.pCompleted.Location = new System.Drawing.Point(290, 121);
            this.pCompleted.Name = "pCompleted";
            this.pCompleted.Size = new System.Drawing.Size(253, 95);
            this.pCompleted.TabIndex = 17;
            // 
            // lblCancelled
            // 
            this.lblCancelled.AutoSize = true;
            this.lblCancelled.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancelled.ForeColor = System.Drawing.Color.White;
            this.lblCancelled.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCancelled.Location = new System.Drawing.Point(46, 12);
            this.lblCancelled.Name = "lblCancelled";
            this.lblCancelled.Size = new System.Drawing.Size(77, 16);
            this.lblCancelled.TabIndex = 0;
            this.lblCancelled.Text = "Cancelled";
            this.lblCancelled.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbCancelled
            // 
            this.pbCancelled.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbCancelled.Image = ((System.Drawing.Image)(resources.GetObject("pbCancelled.Image")));
            this.pbCancelled.Location = new System.Drawing.Point(10, 10);
            this.pbCancelled.Name = "pbCancelled";
            this.pbCancelled.Size = new System.Drawing.Size(20, 20);
            this.pbCancelled.TabIndex = 1;
            this.pbCancelled.TabStop = false;
            // 
            // lblCancelledAppointments
            // 
            this.lblCancelledAppointments.AutoSize = true;
            this.lblCancelledAppointments.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancelledAppointments.ForeColor = System.Drawing.Color.White;
            this.lblCancelledAppointments.Location = new System.Drawing.Point(10, 56);
            this.lblCancelledAppointments.Name = "lblCancelledAppointments";
            this.lblCancelledAppointments.Size = new System.Drawing.Size(25, 25);
            this.lblCancelledAppointments.TabIndex = 2;
            this.lblCancelledAppointments.Text = "0";
            // 
            // pCancelled
            // 
            this.pCancelled.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pCancelled.Controls.Add(this.lblCancelledAppointments);
            this.pCancelled.Controls.Add(this.pbCancelled);
            this.pCancelled.Controls.Add(this.lblCancelled);
            this.pCancelled.Location = new System.Drawing.Point(568, 121);
            this.pCancelled.Name = "pCancelled";
            this.pCancelled.Size = new System.Drawing.Size(253, 95);
            this.pCancelled.TabIndex = 16;
            // 
            // lblFilterBy
            // 
            this.lblFilterBy.AutoSize = true;
            this.lblFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterBy.ForeColor = System.Drawing.Color.LightGray;
            this.lblFilterBy.Location = new System.Drawing.Point(12, 77);
            this.lblFilterBy.Name = "lblFilterBy";
            this.lblFilterBy.Size = new System.Drawing.Size(87, 16);
            this.lblFilterBy.TabIndex = 19;
            this.lblFilterBy.Text = "Filter by date:";
            // 
            // pbClose
            // 
            this.pbClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbClose.Image = ((System.Drawing.Image)(resources.GetObject("pbClose.Image")));
            this.pbClose.Location = new System.Drawing.Point(796, 12);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(25, 25);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClose.TabIndex = 56;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // pFullForm
            // 
            this.pFullForm.Location = new System.Drawing.Point(0, 0);
            this.pFullForm.Name = "pFullForm";
            this.pFullForm.Size = new System.Drawing.Size(833, 536);
            this.pFullForm.TabIndex = 57;
            // 
            // AppointmentDailyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(833, 536);
            this.Controls.Add(this.pbClose);
            this.Controls.Add(this.lblFilterBy);
            this.Controls.Add(this.pCancelled);
            this.Controls.Add(this.pCompleted);
            this.Controls.Add(this.pTodayAppointment);
            this.Controls.Add(this.dtpReportDate);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.dgvAppointmentReportList);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pFullForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AppointmentDailyReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appointment Daily Report";
            this.Load += new System.EventHandler(this.AppointmentDailyReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointmentReportList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTodayAppointment)).EndInit();
            this.pTodayAppointment.ResumeLayout(false);
            this.pTodayAppointment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCompleted)).EndInit();
            this.pCompleted.ResumeLayout(false);
            this.pCompleted.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCancelled)).EndInit();
            this.pCancelled.ResumeLayout(false);
            this.pCancelled.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.DataGridView dgvAppointmentReportList;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DateTimePicker dtpReportDate;
        private System.Windows.Forms.Label lblTodayAppointment;
        private System.Windows.Forms.PictureBox pbTodayAppointment;
        private System.Windows.Forms.Label lblTodaysAppointments;
        private System.Windows.Forms.Panel pTodayAppointment;
        private System.Windows.Forms.Label lblCompleted;
        private System.Windows.Forms.PictureBox pbCompleted;
        private System.Windows.Forms.Label lblCompletedAppointments;
        private System.Windows.Forms.Panel pCompleted;
        private System.Windows.Forms.Label lblCancelled;
        private System.Windows.Forms.PictureBox pbCancelled;
        private System.Windows.Forms.Label lblCancelledAppointments;
        private System.Windows.Forms.Panel pCancelled;
        private System.Windows.Forms.Label lblFilterBy;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.Panel pFullForm;
    }
}