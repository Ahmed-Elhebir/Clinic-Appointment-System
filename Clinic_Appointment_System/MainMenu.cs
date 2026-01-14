using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Clinic_Appointment_System.Appointment;
using Clinic_Appointment_System.UserControls;
using Clinic_Appointment_System_Business_Layer;
using Clinic_Appointment_System_Global;
using Clinic_Appointment_System_Global.DTOs.User;

namespace Clinic_Appointment_System
{
    public partial class MainMenu : Form
    {
        private UserControl currentControl;
        private readonly Dictionary<string, UserControl> _controls = new Dictionary<string, UserControl>();
        UserDTO userDTO;

        // Demo login and will be changed later after making log in screen.
        private void LoginUser()
        {
            userDTO = UserService.Find("Ahmed", "123456789");
            if (userDTO == null)
            {
                MessageBox.Show("User name not found.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            CurrentUser.UserID = userDTO.UserID;
            CurrentUser.UserName = userDTO.UserName;
            CurrentUser.UserRole = userDTO.Role;
        }

        public MainMenu()
        {
            InitializeComponent();
            ThemeColors.ApplyTheme(false);
            timer.Start();
            FormDragHelper.EnableDrag(this.pStatus);
            LoginUser();
            UC_Settings.OnSettingsChanged += ThemeChanged;
        }

        private void ThemeChanged(object sender, SettingsEventArgs e)
        {
            ApplyTheme();
            btnSettings.Image = ThemeColors.SelectedSettingsIcon;
            btnSettings.BackColor = ThemeColors.MainButtonClickedBackground;
            btnSettings.ForeColor = ThemeColors.MainButtonClickedForeground;
        }

        private void ApplyTheme()
        {
            SetColor();
            SetIcons();
        }

        private void SetColor()
        {
            #region Background Colors
            this.BackColor = ThemeColors.MainBackground;
            pStatus.BackColor = ThemeColors.TopPanel;
            pMenu.BackColor = ThemeColors.MenuPanel;
            pUserInfo.BackColor = ThemeColors.UserInfoPanel;
            pTitle.BackColor = ThemeColors.TitlePanel;
            pVersion.BackColor = ThemeColors.VersionPanel;
            #endregion

            #region Label Colors
            lblCurrentTime.ForeColor = ThemeColors.MainLabelText;
            lblCurrentDate.ForeColor = ThemeColors.SecondaryLabelText;
            lblUserName.ForeColor = ThemeColors.MainLabelText;
            lblUserRole.ForeColor = ThemeColors.SecondaryLabelText;
            lblTitle.ForeColor = ThemeColors.MainLabelText;
            lblVersion.ForeColor = ThemeColors.SecondaryLabelText;
            #endregion

            #region Menu Button Colors
            btnDashboard.BackColor = ThemeColors.MainButtonBackground;
            btnDashboard.ForeColor = ThemeColors.MainButtonForeground;

            btnAppointments.BackColor = ThemeColors.MainButtonBackground;
            btnAppointments.ForeColor = ThemeColors.MainButtonForeground;

            btnPatients.BackColor = ThemeColors.MainButtonBackground;
            btnPatients.ForeColor = ThemeColors.MainButtonForeground;

            btnDoctors.BackColor = ThemeColors.MainButtonBackground;
            btnDoctors.ForeColor = ThemeColors.MainButtonForeground;

            btnUsers.BackColor = ThemeColors.MainButtonBackground;
            btnUsers.ForeColor = ThemeColors.MainButtonForeground;

            btnDailyReport.BackColor = ThemeColors.MainButtonBackground;
            btnDailyReport.ForeColor = ThemeColors.MainButtonForeground;

            btnSettings.BackColor = ThemeColors.MainButtonBackground;
            btnSettings.ForeColor = ThemeColors.MainButtonForeground;
            #endregion
        }

        private void SetIcons()
        {
            pbDateTime.Image = ThemeColors.DateTimeIcon;
            pbClose.Image = ThemeColors.CloseIcon;
            
            btnDashboard.Image = ThemeColors.DashboardIcon;
            btnAppointments.Image = ThemeColors.AppointmentsIcon;
            btnPatients.Image = ThemeColors.PatientsIcon;
            btnDoctors.Image = ThemeColors.DoctorsIcon;
            btnUsers.Image = ThemeColors.UsersIcon;
            btnDailyReport.Image = ThemeColors.DailyReportIcon;
            btnSettings.Image = ThemeColors.SettingsIcon;            
        }

        private void HoverOnButton(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Tag.ToString() != "Active")
                btn.BackColor = ThemeColors.MainButtonHoverBackground;
        }

        private void EndHoverOnButton(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Tag.ToString() != "Active")
                btn.BackColor = ThemeColors.MainButtonBackground;
        }

        private void ResetButtonIcons()
        {
            btnDashboard.Image = ThemeColors.DashboardIcon;
            btnAppointments.Image = ThemeColors.AppointmentsIcon;
            btnPatients.Image = ThemeColors.PatientsIcon;
            btnDoctors.Image = ThemeColors.DoctorsIcon;
            btnUsers.Image = ThemeColors.UsersIcon;
            btnDailyReport.Image = ThemeColors.DailyReportIcon;
            btnSettings.Image = ThemeColors.SettingsIcon;
        }

        private void ResetButtonColors()
        {
            Button[] buttons = { btnDashboard, btnAppointments, btnPatients, btnDoctors, btnUsers, btnDailyReport, btnSettings };

            foreach (Button btn in buttons)
            {
                btn.BackColor = ThemeColors.MainButtonBackground;
                btn.ForeColor = ThemeColors.MainButtonForeground;
                btn.Tag = "";
            }
            ResetButtonIcons();
        }

        private void NavigateToControl<T>(object sender, Image buttonImage) where T : UserControl, new()
        {
            Button clickedButton = (Button)sender;

            AddUserControl(typeof(T).Name, () => new T());
            ResetButtonColors();
            clickedButton.BackColor = ThemeColors.MainButtonClickedBackground;
            clickedButton.ForeColor = ThemeColors.MainButtonClickedForeground;
            clickedButton.Image = buttonImage;
            clickedButton.Tag = "Active";
        }

        private void AddUserControl(string key, Func<UserControl> factory)
        {
            if (!_controls.TryGetValue(key, out var control))
            {
                control = factory();
                control.Dock = DockStyle.Fill;
                _controls[key] = control;
            }

            if (currentControl != null)
                panelContainer.Controls.Remove(currentControl);

            panelContainer.Controls.Add(control);
            control.BringToFront();
            currentControl = control;

        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            NavigateToControl<UC_Dashboard>(sender, ThemeColors.SelectedDashboardIcon);
        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            NavigateToControl<UC_Appointments>(sender, ThemeColors.SelectedAppointmentsIcon);
        }

        private void btnPatients_Click(object sender, EventArgs e)
        {
            NavigateToControl<UC_Patients>(sender, ThemeColors.SelectedPatientsIcon);
        }

        private void btnDoctors_Click(object sender, EventArgs e)
        {
            NavigateToControl<UC_Doctors>(sender, ThemeColors.SelectedDoctorsIcon);
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            NavigateToControl<UC_Users>(sender, ThemeColors.SelectedUsersIcon);
        }

        private void btnDailyReport_Click(object sender, EventArgs e)
        {
            AppointmentDailyReport report = new AppointmentDailyReport();
            report.ShowDialog();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            NavigateToControl<UC_Settings>(sender, ThemeColors.SelectedSettingsIcon);
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            ApplyTheme();
            NavigateToControl<UC_Appointments>(btnAppointments, ThemeColors.SelectedAppointmentsIcon);

            if (userDTO != null)
            {
                lblUserName.Text = userDTO.PersonDTO.FullName;
                pUserInfo.Width = lblUserName.Width + 20;
                pUserInfo.Left = pUserInfo.Left - lblUserName.Width / 2;
                lblUserRole.Text = userDTO.Role;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblCurrentTime.Text = DateTime.Now.ToString("HH:mm:ss");
            lblCurrentDate.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy");
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
