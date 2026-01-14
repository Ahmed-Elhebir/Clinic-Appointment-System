namespace Clinic_Appointment_System.UserControls
{
    partial class UC_Appointments
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Appointments));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.pTodayAppointments = new System.Windows.Forms.Panel();
            this.lblTodaysAppointments = new System.Windows.Forms.Label();
            this.pbTodayAppointments = new System.Windows.Forms.PictureBox();
            this.lblTodayAppointmnetsTitle = new System.Windows.Forms.Label();
            this.pPending = new System.Windows.Forms.Panel();
            this.lblPending = new System.Windows.Forms.Label();
            this.pbPending = new System.Windows.Forms.PictureBox();
            this.lblPendingTitle = new System.Windows.Forms.Label();
            this.pInProgress = new System.Windows.Forms.Panel();
            this.lblInProgress = new System.Windows.Forms.Label();
            this.pbInProgress = new System.Windows.Forms.PictureBox();
            this.lblInProgressTitle = new System.Windows.Forms.Label();
            this.pCompleted = new System.Windows.Forms.Panel();
            this.lblCompletedAppointments = new System.Windows.Forms.Label();
            this.pbCompleted = new System.Windows.Forms.PictureBox();
            this.lblCompletedTitle = new System.Windows.Forms.Label();
            this.txtFilterBy = new System.Windows.Forms.TextBox();
            this.lblFilterBy = new System.Windows.Forms.Label();
            this.lblRecord = new System.Windows.Forms.Label();
            this.dgvAppointmentList = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.completeAppointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payPaymentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.btnAddAppointment = new System.Windows.Forms.Button();
            this.pTodayAppointments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTodayAppointments)).BeginInit();
            this.pPending.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPending)).BeginInit();
            this.pInProgress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbInProgress)).BeginInit();
            this.pCompleted.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCompleted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointmentList)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(15, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(192, 31);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Appointments";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.ForeColor = System.Drawing.Color.LightGray;
            this.lblDescription.Location = new System.Drawing.Point(15, 56);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(268, 16);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Manage and schedule patient appointments";
            // 
            // pTodayAppointments
            // 
            this.pTodayAppointments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pTodayAppointments.Controls.Add(this.lblTodaysAppointments);
            this.pTodayAppointments.Controls.Add(this.pbTodayAppointments);
            this.pTodayAppointments.Controls.Add(this.lblTodayAppointmnetsTitle);
            this.pTodayAppointments.Location = new System.Drawing.Point(15, 113);
            this.pTodayAppointments.Name = "pTodayAppointments";
            this.pTodayAppointments.Size = new System.Drawing.Size(253, 95);
            this.pTodayAppointments.TabIndex = 2;
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
            // pbTodayAppointments
            // 
            this.pbTodayAppointments.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbTodayAppointments.Image = ((System.Drawing.Image)(resources.GetObject("pbTodayAppointments.Image")));
            this.pbTodayAppointments.Location = new System.Drawing.Point(10, 10);
            this.pbTodayAppointments.Name = "pbTodayAppointments";
            this.pbTodayAppointments.Size = new System.Drawing.Size(20, 20);
            this.pbTodayAppointments.TabIndex = 1;
            this.pbTodayAppointments.TabStop = false;
            // 
            // lblTodayAppointmnetsTitle
            // 
            this.lblTodayAppointmnetsTitle.AutoSize = true;
            this.lblTodayAppointmnetsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTodayAppointmnetsTitle.ForeColor = System.Drawing.Color.White;
            this.lblTodayAppointmnetsTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTodayAppointmnetsTitle.Location = new System.Drawing.Point(46, 12);
            this.lblTodayAppointmnetsTitle.Name = "lblTodayAppointmnetsTitle";
            this.lblTodayAppointmnetsTitle.Size = new System.Drawing.Size(162, 16);
            this.lblTodayAppointmnetsTitle.TabIndex = 0;
            this.lblTodayAppointmnetsTitle.Text = "Today\'s Appointments";
            this.lblTodayAppointmnetsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pPending
            // 
            this.pPending.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pPending.Controls.Add(this.lblPending);
            this.pPending.Controls.Add(this.pbPending);
            this.pPending.Controls.Add(this.lblPendingTitle);
            this.pPending.Location = new System.Drawing.Point(293, 113);
            this.pPending.Name = "pPending";
            this.pPending.Size = new System.Drawing.Size(253, 95);
            this.pPending.TabIndex = 3;
            // 
            // lblPending
            // 
            this.lblPending.AutoSize = true;
            this.lblPending.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPending.ForeColor = System.Drawing.Color.White;
            this.lblPending.Location = new System.Drawing.Point(10, 56);
            this.lblPending.Name = "lblPending";
            this.lblPending.Size = new System.Drawing.Size(111, 16);
            this.lblPending.TabIndex = 2;
            this.lblPending.Text = "Comming Soon";
            // 
            // pbPending
            // 
            this.pbPending.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbPending.Image = ((System.Drawing.Image)(resources.GetObject("pbPending.Image")));
            this.pbPending.Location = new System.Drawing.Point(10, 10);
            this.pbPending.Name = "pbPending";
            this.pbPending.Size = new System.Drawing.Size(20, 20);
            this.pbPending.TabIndex = 1;
            this.pbPending.TabStop = false;
            // 
            // lblPendingTitle
            // 
            this.lblPendingTitle.AutoSize = true;
            this.lblPendingTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPendingTitle.ForeColor = System.Drawing.Color.White;
            this.lblPendingTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPendingTitle.Location = new System.Drawing.Point(46, 12);
            this.lblPendingTitle.Name = "lblPendingTitle";
            this.lblPendingTitle.Size = new System.Drawing.Size(64, 16);
            this.lblPendingTitle.TabIndex = 0;
            this.lblPendingTitle.Text = "Pending";
            this.lblPendingTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pInProgress
            // 
            this.pInProgress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pInProgress.Controls.Add(this.lblInProgress);
            this.pInProgress.Controls.Add(this.pbInProgress);
            this.pInProgress.Controls.Add(this.lblInProgressTitle);
            this.pInProgress.Location = new System.Drawing.Point(571, 113);
            this.pInProgress.Name = "pInProgress";
            this.pInProgress.Size = new System.Drawing.Size(253, 95);
            this.pInProgress.TabIndex = 3;
            // 
            // lblInProgress
            // 
            this.lblInProgress.AutoSize = true;
            this.lblInProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInProgress.ForeColor = System.Drawing.Color.White;
            this.lblInProgress.Location = new System.Drawing.Point(10, 56);
            this.lblInProgress.Name = "lblInProgress";
            this.lblInProgress.Size = new System.Drawing.Size(111, 16);
            this.lblInProgress.TabIndex = 2;
            this.lblInProgress.Text = "Comming Soon";
            // 
            // pbInProgress
            // 
            this.pbInProgress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbInProgress.Image = ((System.Drawing.Image)(resources.GetObject("pbInProgress.Image")));
            this.pbInProgress.Location = new System.Drawing.Point(10, 10);
            this.pbInProgress.Name = "pbInProgress";
            this.pbInProgress.Size = new System.Drawing.Size(20, 20);
            this.pbInProgress.TabIndex = 1;
            this.pbInProgress.TabStop = false;
            // 
            // lblInProgressTitle
            // 
            this.lblInProgressTitle.AutoSize = true;
            this.lblInProgressTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInProgressTitle.ForeColor = System.Drawing.Color.White;
            this.lblInProgressTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblInProgressTitle.Location = new System.Drawing.Point(46, 12);
            this.lblInProgressTitle.Name = "lblInProgressTitle";
            this.lblInProgressTitle.Size = new System.Drawing.Size(86, 16);
            this.lblInProgressTitle.TabIndex = 0;
            this.lblInProgressTitle.Text = "In Progress";
            this.lblInProgressTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pCompleted
            // 
            this.pCompleted.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pCompleted.Controls.Add(this.lblCompletedAppointments);
            this.pCompleted.Controls.Add(this.pbCompleted);
            this.pCompleted.Controls.Add(this.lblCompletedTitle);
            this.pCompleted.Location = new System.Drawing.Point(849, 113);
            this.pCompleted.Name = "pCompleted";
            this.pCompleted.Size = new System.Drawing.Size(253, 95);
            this.pCompleted.TabIndex = 3;
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
            // lblCompletedTitle
            // 
            this.lblCompletedTitle.AutoSize = true;
            this.lblCompletedTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompletedTitle.ForeColor = System.Drawing.Color.White;
            this.lblCompletedTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCompletedTitle.Location = new System.Drawing.Point(46, 12);
            this.lblCompletedTitle.Name = "lblCompletedTitle";
            this.lblCompletedTitle.Size = new System.Drawing.Size(82, 16);
            this.lblCompletedTitle.TabIndex = 0;
            this.lblCompletedTitle.Text = "Completed";
            this.lblCompletedTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtFilterBy
            // 
            this.txtFilterBy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txtFilterBy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterBy.ForeColor = System.Drawing.Color.White;
            this.txtFilterBy.Location = new System.Drawing.Point(218, 242);
            this.txtFilterBy.Name = "txtFilterBy";
            this.txtFilterBy.Size = new System.Drawing.Size(218, 22);
            this.txtFilterBy.TabIndex = 4;
            this.txtFilterBy.TextChanged += new System.EventHandler(this.txtFilterBy_TextChanged);
            this.txtFilterBy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterBy_KeyPress);
            // 
            // lblFilterBy
            // 
            this.lblFilterBy.AutoSize = true;
            this.lblFilterBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFilterBy.ForeColor = System.Drawing.Color.White;
            this.lblFilterBy.Location = new System.Drawing.Point(15, 245);
            this.lblFilterBy.Name = "lblFilterBy";
            this.lblFilterBy.Size = new System.Drawing.Size(58, 16);
            this.lblFilterBy.TabIndex = 5;
            this.lblFilterBy.Text = "Filter By:";
            // 
            // lblRecord
            // 
            this.lblRecord.AutoSize = true;
            this.lblRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecord.ForeColor = System.Drawing.Color.LightGray;
            this.lblRecord.Location = new System.Drawing.Point(15, 293);
            this.lblRecord.Name = "lblRecord";
            this.lblRecord.Size = new System.Drawing.Size(25, 13);
            this.lblRecord.TabIndex = 6;
            this.lblRecord.Text = "???";
            // 
            // dgvAppointmentList
            // 
            this.dgvAppointmentList.AllowUserToAddRows = false;
            this.dgvAppointmentList.AllowUserToDeleteRows = false;
            this.dgvAppointmentList.AllowUserToResizeColumns = false;
            this.dgvAppointmentList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.LightGray;
            this.dgvAppointmentList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAppointmentList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAppointmentList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.dgvAppointmentList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAppointmentList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvAppointmentList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAppointmentList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAppointmentList.ColumnHeadersHeight = 28;
            this.dgvAppointmentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvAppointmentList.ContextMenuStrip = this.contextMenuStrip;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(100)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAppointmentList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAppointmentList.EnableHeadersVisualStyles = false;
            this.dgvAppointmentList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.dgvAppointmentList.Location = new System.Drawing.Point(15, 322);
            this.dgvAppointmentList.MultiSelect = false;
            this.dgvAppointmentList.Name = "dgvAppointmentList";
            this.dgvAppointmentList.ReadOnly = true;
            this.dgvAppointmentList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvAppointmentList.RowHeadersVisible = false;
            this.dgvAppointmentList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.LightGray;
            this.dgvAppointmentList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvAppointmentList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAppointmentList.Size = new System.Drawing.Size(1087, 250);
            this.dgvAppointmentList.TabIndex = 7;
            this.dgvAppointmentList.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAppointmentList_CellMouseDown);
            this.dgvAppointmentList.DoubleClick += new System.EventHandler(this.dgvAppointmentList_DoubleClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAppointmentToolStripMenuItem,
            this.editAppointmentToolStripMenuItem,
            this.cancelAppointmentToolStripMenuItem,
            this.completeAppointmentToolStripMenuItem,
            this.payPaymentsToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(201, 136);
            this.contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
            // 
            // addAppointmentToolStripMenuItem
            // 
            this.addAppointmentToolStripMenuItem.Name = "addAppointmentToolStripMenuItem";
            this.addAppointmentToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.addAppointmentToolStripMenuItem.Text = "Add Appointment";
            this.addAppointmentToolStripMenuItem.Click += new System.EventHandler(this.addAppointmentToolStripMenuItem_Click);
            // 
            // editAppointmentToolStripMenuItem
            // 
            this.editAppointmentToolStripMenuItem.Name = "editAppointmentToolStripMenuItem";
            this.editAppointmentToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.editAppointmentToolStripMenuItem.Text = "Edit Appointment";
            this.editAppointmentToolStripMenuItem.Click += new System.EventHandler(this.editAppointmentToolStripMenuItem_Click);
            // 
            // cancelAppointmentToolStripMenuItem
            // 
            this.cancelAppointmentToolStripMenuItem.Name = "cancelAppointmentToolStripMenuItem";
            this.cancelAppointmentToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.cancelAppointmentToolStripMenuItem.Text = "Cancel Appointment";
            this.cancelAppointmentToolStripMenuItem.Click += new System.EventHandler(this.cancelAppointmentToolStripMenuItem_Click);
            // 
            // completeAppointmentToolStripMenuItem
            // 
            this.completeAppointmentToolStripMenuItem.Name = "completeAppointmentToolStripMenuItem";
            this.completeAppointmentToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.completeAppointmentToolStripMenuItem.Text = "Complete Appointment";
            this.completeAppointmentToolStripMenuItem.Click += new System.EventHandler(this.completeAppointmentToolStripMenuItem_Click);
            // 
            // payPaymentsToolStripMenuItem
            // 
            this.payPaymentsToolStripMenuItem.Name = "payPaymentsToolStripMenuItem";
            this.payPaymentsToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.payPaymentsToolStripMenuItem.Text = "Pay payments";
            this.payPaymentsToolStripMenuItem.Click += new System.EventHandler(this.payPaymentsToolStripMenuItem_Click);
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Items.AddRange(new object[] {
            "AppointmentID",
            "PatientName",
            "DoctorName"});
            this.cbFilterBy.Location = new System.Drawing.Point(80, 243);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(121, 21);
            this.cbFilterBy.TabIndex = 8;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // btnAddAppointment
            // 
            this.btnAddAppointment.BackColor = System.Drawing.Color.LightGray;
            this.btnAddAppointment.Image = ((System.Drawing.Image)(resources.GetObject("btnAddAppointment.Image")));
            this.btnAddAppointment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddAppointment.Location = new System.Drawing.Point(917, 50);
            this.btnAddAppointment.Name = "btnAddAppointment";
            this.btnAddAppointment.Size = new System.Drawing.Size(185, 29);
            this.btnAddAppointment.TabIndex = 9;
            this.btnAddAppointment.Text = "Schedule Appointment";
            this.btnAddAppointment.UseVisualStyleBackColor = false;
            this.btnAddAppointment.Click += new System.EventHandler(this.btnAddAppointment_Click);
            // 
            // UC_Appointments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.Controls.Add(this.btnAddAppointment);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.dgvAppointmentList);
            this.Controls.Add(this.lblRecord);
            this.Controls.Add(this.lblFilterBy);
            this.Controls.Add(this.txtFilterBy);
            this.Controls.Add(this.pCompleted);
            this.Controls.Add(this.pInProgress);
            this.Controls.Add(this.pPending);
            this.Controls.Add(this.pTodayAppointments);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblTitle);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "UC_Appointments";
            this.Size = new System.Drawing.Size(1133, 591);
            this.Load += new System.EventHandler(this.UC_Appointments_Load);
            this.VisibleChanged += new System.EventHandler(this.UC_Appointments_VisibleChanged);
            this.pTodayAppointments.ResumeLayout(false);
            this.pTodayAppointments.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTodayAppointments)).EndInit();
            this.pPending.ResumeLayout(false);
            this.pPending.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPending)).EndInit();
            this.pInProgress.ResumeLayout(false);
            this.pInProgress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbInProgress)).EndInit();
            this.pCompleted.ResumeLayout(false);
            this.pCompleted.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCompleted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointmentList)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Panel pTodayAppointments;
        private System.Windows.Forms.PictureBox pbTodayAppointments;
        private System.Windows.Forms.Label lblTodayAppointmnetsTitle;
        private System.Windows.Forms.Label lblTodaysAppointments;
        private System.Windows.Forms.Panel pPending;
        private System.Windows.Forms.Label lblPending;
        private System.Windows.Forms.PictureBox pbPending;
        private System.Windows.Forms.Label lblPendingTitle;
        private System.Windows.Forms.Panel pInProgress;
        private System.Windows.Forms.Label lblInProgress;
        private System.Windows.Forms.PictureBox pbInProgress;
        private System.Windows.Forms.Label lblInProgressTitle;
        private System.Windows.Forms.Panel pCompleted;
        private System.Windows.Forms.Label lblCompletedAppointments;
        private System.Windows.Forms.PictureBox pbCompleted;
        private System.Windows.Forms.Label lblCompletedTitle;
        private System.Windows.Forms.TextBox txtFilterBy;
        private System.Windows.Forms.Label lblFilterBy;
        private System.Windows.Forms.Label lblRecord;
        private System.Windows.Forms.DataGridView dgvAppointmentList;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Button btnAddAppointment;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem addAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem completeAppointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payPaymentsToolStripMenuItem;
    }
}
