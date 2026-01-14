using Clinic_Appointment_System.Properties;
using System.Drawing;
using System.Web.UI;

namespace Clinic_Appointment_System
{
    public static class ThemeColors
    {
        #region Background Colors
        public static Color MainBackground { get; set; }
        public static Color TopPanel { get; set; }
        public static Color MenuPanel { get; set; }
        public static Color VersionPanel { get; set; }
        public static Color TitlePanel { get; set; }
        public static Color UserInfoPanel { get; set; }
        #endregion

        #region Label Colors
        public static Color MainLabelText { get; set; }
        public static Color SecondaryLabelText { get; set; }
        #endregion

        #region Main Button Colors
        public static Color MainButtonBackground { get; set; }
        public static Color MainButtonForeground { get; set; }
        public static Color MainButtonClickedBackground { get; set; }
        public static Color MainButtonClickedForeground { get; set; }
        public static Color MainButtonHoverBackground { get; set; }
        #endregion

        #region Secondary Button Colors
        public static Color SecondaryButtonBackground { get; set; }
        public static Color SecondaryButtonForeground { get; set; }
        public static Color SecondaryButtonHoverBackground { get; set; }
        #endregion

        #region DataGridView Colors
        public static Color ColumnHeaderBackColor { get; set; }
        public static Color ColumnHeaderForeColor { get; set; }
        public static Color AlternatingCellBackColor { get; set; }
        public static Color AlternatingCellForeColor { get; set; }
        public static Color AlternatingCellSelectionBackColor { get; set; }
        public static Color AlternatingCellSelectionForeColor { get; set; }
        public static Color RowsCellBackColor { get; set; }
        public static Color RowsCellForeColor { get; set; }
        public static Color RowsCellSelectionBackColor { get; set; }
        public static Color RowsCellSelectionForeColor { get; set; }
        #endregion

        #region Setting Button Colors
        public static Color LightButtonBackColor { get; set; }
        public static Color LightButtonForeColor { get; set; }
        public static Color LightButtonHoverColor { get; set; }
        public static Color DarkButtonBackColor { get; set; }
        public static Color DarkButtonForeColor { get; set; }
        public static Color DarkButtonHoverColor { get; set; }
        #endregion

        #region Text Box Colors
        public static Color TextBoxBackColor { get; set; }
        public static Color TextBoxForeColor { get; set; }
        #endregion

        #region Common Colors
        public static Color SaveButtonBackColor { get; set; }
        public static Color SaveButtonForeColor { get; set; }
        public static Color DisableSaveButtonForeColor { get; set; }
        public static Color CancelButtonBackColor { get; set; }
        public static Color CancelButtonForeColor { get; set; }
        public static Color PayButtonBackColor { get; set; }
        public static Color PayButtonForeColor { get; set; }
        #endregion

        #region Common Icons
        public static Image CloseIcon { get; set; }
        public static Image DateTimeIcon { get; set; }
        public static Image SaveIcon { get; set; }
        public static Image CancelIcon { get; set; }
        public static Image SearchIcon { get; set; }
        public static Image PayIcon { get; set; }
        #endregion

        #region Selected Menu Icons
        public static Image SelectedDashboardIcon { get; set; }
        public static Image SelectedAppointmentsIcon { get; set; }
        public static Image SelectedPatientsIcon { get; set; }
        public static Image SelectedDoctorsIcon { get; set; }
        public static Image SelectedUsersIcon { get; set; }
        public static Image SelectedDailyReportIcon { get; set; }
        public static Image SelectedSettingsIcon { get; set; }
        #endregion

        #region Menu Icons
        public static Image DashboardIcon { get; set; }
        public static Image AppointmentsIcon { get; set; }
        public static Image PatientsIcon { get; set; }
        public static Image DoctorsIcon { get; set; }
        public static Image UsersIcon { get; set; }
        public static Image DailyReportIcon { get; set; }
        public static Image SettingsIcon { get; set; }
        #endregion

        #region Appointment Screen Icons
        public static Image AddAppointmentIcon { get; set; }
        public static Image AddAppointmentIconButton {  get; set; }
        public static Image TodaysAppointmnetIcon { get; set; }
        public static Image PendingAppointmentIcon { get; set; }
        public static Image InProgressAppointmentIcon { get; set; }
        public static Image CompletedAppointmentIcon { get; set; }
        public static Image CompletedAppointmentItemIcon { get; set; }
        public static Image CancelledAppointmentIcon { get; set; }
        public static Image PaymentsIcon { get; set; }
        public static Image EditAppointmnetIcon { get; set; }
        #endregion

        #region Doctor Screen Icons
        public static Image AddDoctorButtonIcon { get; set; }
        public static Image AddDoctorIcon { get; set; }
        public static Image EditDoctorIcon { get; set; }
        public static Image DeleteDoctorIcon { get; set; }
        #endregion

        #region Settings Screen Icons
        public static Image LightButtonIcon { get; set; }
        public static Image DarkButtonIcon { get; set; }
        public static Image AppearanceIcon { get; set; }
        #endregion

        #region Patient Screen Icons
        public static Image AddPatientButtonIcon { get; set; }
        #endregion

        #region Add Edit Appointment Screen Colors
        #endregion

        #region Daily Report Screen Icons
        public static Image GenerateDailyReportButtonIcon { get; set; }
        #endregion


        public static void ApplyTheme(bool isDark)
        {
            if (isDark)
                SetDarkTheme();
            else 
                SetLightTheme();
        }

        public static void SetDarkTheme()
        {
            #region Background Colors
            MainBackground = Color.FromArgb(10, 10, 10);
            TopPanel = Color.FromArgb(10, 10, 10);
            MenuPanel = Color.FromArgb(23, 23, 23);
            VersionPanel = Color.FromArgb(23, 23, 23);
            TitlePanel = Color.FromArgb(23, 23, 23);
            UserInfoPanel = Color.FromArgb(10, 10, 10);
            #endregion

            #region Label Colors
            MainLabelText = Color.FromArgb(255, 255, 255);
            SecondaryLabelText = Color.FromArgb(160, 160, 160);
            #endregion

            #region Main Button Colors
            MainButtonBackground = Color.Transparent;
            MainButtonForeground = Color.FromArgb(255, 255, 255);
            MainButtonClickedBackground = Color.FromArgb(20, 71, 230);
            MainButtonClickedForeground = Color.FromArgb(250, 250, 250);
            MainButtonHoverBackground = Color.FromArgb(30, 30, 30);
            #endregion

            #region Secondary Button Colors
            SecondaryButtonBackground = Color.FromArgb(250, 250, 250);
            SecondaryButtonForeground = Color.FromArgb(10, 10, 10);
            SecondaryButtonHoverBackground = Color.FromArgb(24, 24, 24);
            #endregion

            #region DataGridView Colors
            ColumnHeaderBackColor = Color.FromArgb(45, 45, 45);
            ColumnHeaderForeColor = Color.FromArgb(255, 255, 255);
            AlternatingCellBackColor = Color.FromArgb(45, 45, 45);
            AlternatingCellForeColor = Color.FromArgb(255, 255, 255);
            AlternatingCellSelectionBackColor = Color.DimGray;
            AlternatingCellSelectionForeColor = Color.FromArgb(255, 255, 255);
            RowsCellBackColor = Color.FromArgb(23, 23, 23);
            RowsCellForeColor = Color.FromArgb(255, 255, 255);
            RowsCellSelectionBackColor = Color.DimGray;
            RowsCellSelectionForeColor = Color.FromArgb(255, 255, 255);
            #endregion

            #region Setting Button Colors
            LightButtonBackColor = Color.FromArgb(18, 18, 18);
            LightButtonForeColor = Color.FromArgb(255, 255, 255);
            LightButtonHoverColor = Color.FromArgb(24, 24, 24);
            DarkButtonBackColor = Color.FromArgb(250, 250, 250);
            DarkButtonForeColor = Color.FromArgb(10, 10, 10);
            DarkButtonHoverColor = Color.FromArgb(226, 226, 226);
            #endregion

            #region Text Box Colors
            TextBoxBackColor = Color.FromArgb(3, 2, 19);
            TextBoxForeColor = Color.FromArgb(255, 255, 255);
            #endregion

            #region Common Colors
            SaveButtonBackColor = Color.FromArgb(250, 250, 250);
            SaveButtonForeColor = Color.FromArgb(10, 10, 10);
            DisableSaveButtonForeColor = Color.FromArgb(150, 150, 150);
            CancelButtonBackColor = Color.FromArgb(10, 10, 10);
            CancelButtonForeColor = Color.FromArgb(250, 250, 250);
            PayButtonBackColor = Color.FromArgb(250, 250, 250);
            PayButtonForeColor = Color.FromArgb(10, 10, 10);
            #endregion

            #region Common Icons
            CloseIcon = Resources.Close_White_20;
            DateTimeIcon = Resources.Time_White_20;
            SaveIcon = Resources.Save_Black_20;
            CancelIcon = Resources.Cancel_White_20;
            SearchIcon = Resources.Search_Black_20;
            PayIcon = Resources.Pay_Black_20;
            #endregion

            #region Menu Icons
            DashboardIcon = Resources.Dashboard_White_20;
            AppointmentsIcon = Resources.Appointment_White_20;
            PatientsIcon = Resources.Patient_White_20;
            DoctorsIcon = Resources.Doctor_White_20;
            UsersIcon = Resources.Users_White_20;
            DailyReportIcon = Resources.Report_White_20;
            SettingsIcon = Resources.Settings_White_20;
            #endregion

            #region Selected Menu Icons
            SelectedDashboardIcon = Resources.Dashboard_White_20;
            SelectedAppointmentsIcon = Resources.Appointment_White_20;
            SelectedPatientsIcon = Resources.Patient_White_20;
            SelectedDoctorsIcon = Resources.Doctor_White_20;
            SelectedUsersIcon = Resources.Users_White_20;
            SelectedDailyReportIcon = Resources.Report_White_20;
            SelectedSettingsIcon = Resources.Settings_White_20;
            #endregion

            #region Appointment Screen Icons
            AddAppointmentIconButton = Resources.Add_Appointment_Black_20;
            AddAppointmentIcon = Resources.Add_Appointment_Black_20;
            TodaysAppointmnetIcon = Resources.Appointment_White_20;
            PendingAppointmentIcon = Resources.Time_White_20;
            InProgressAppointmentIcon = Resources.In_Progress_White_20;
            CompletedAppointmentIcon = Resources.Completed_Appointment_White_20;
            CompletedAppointmentItemIcon = Resources.Completed_Appointment_Black_20;
            PaymentsIcon = Resources.Payment_Black_20;
            CancelledAppointmentIcon = Resources.Cancel_Appointment_Black_20;
            EditAppointmnetIcon = Resources.Edit_Appointment_Black_20;
            #endregion

            #region Doctor Screen Icons
            AddDoctorButtonIcon = Resources.Add_Doctor_Black_20;
            AddDoctorIcon = Resources.Add_Doctor_Black_20;
            EditDoctorIcon = Resources.Edit_Doctor_Black_20;
            DeleteDoctorIcon = Resources.Delete_Doctor_Black_20;
            #endregion

            #region Setting Screen Icons
            LightButtonIcon = Resources.Light_Mode_White_20;
            DarkButtonIcon = Resources.Dark_Mode_Black_20;
            AppearanceIcon = Resources.Appearance_White_20;
            #endregion

            #region Patient Screen Icons
            AddPatientButtonIcon = Resources.Add_Patient_Black_20;
            #endregion

            #region Daily Report Screen Icons
            GenerateDailyReportButtonIcon = Resources.Daily_Report_Black_20;
            #endregion

        }

        public static void SetLightTheme()
        {
            #region Background Colors
            MainBackground = Color.FromArgb(255, 255, 255);
            TopPanel = Color.FromArgb(255, 255, 255);
            MenuPanel = Color.FromArgb(250, 250, 250);
            VersionPanel = Color.FromArgb(250, 250, 250);
            TitlePanel = Color.FromArgb(250, 250, 250);
            UserInfoPanel = Color.FromArgb(255, 255, 255);
            #endregion

            #region Label Colors
            MainLabelText = Color.FromArgb(10, 10, 10);
            SecondaryLabelText = Color.FromArgb(44, 44, 44);
            #endregion

            #region Main Button Colors
            MainButtonBackground = Color.Transparent;
            MainButtonForeground = Color.FromArgb(10, 10, 10);
            MainButtonClickedBackground = Color.FromArgb(3, 2, 19);
            MainButtonClickedForeground = Color.FromArgb(250, 250, 250);
            MainButtonHoverBackground = Color.FromArgb(245, 245, 245);
            #endregion

            #region Secondary Button Colors
            SecondaryButtonBackground = Color.FromArgb(3, 2, 19);
            SecondaryButtonForeground = Color.FromArgb(255, 255, 255);
            SecondaryButtonHoverBackground = Color.FromArgb(233, 235, 239);
            #endregion

            #region DataGridView Colors
            ColumnHeaderBackColor = Color.FromArgb(200, 200, 200);
            ColumnHeaderForeColor = Color.FromArgb(10, 10, 10);
            AlternatingCellBackColor = Color.FromArgb(200, 200, 200);
            AlternatingCellForeColor = Color.FromArgb(10, 10, 10);
            AlternatingCellSelectionBackColor = Color.FromArgb(40, 100, 255);
            AlternatingCellSelectionForeColor = Color.FromArgb(255, 255, 255);
            RowsCellBackColor = Color.FromArgb(245, 245, 245);
            RowsCellForeColor = Color.FromArgb(10, 10, 10);
            RowsCellSelectionBackColor = Color.FromArgb(40, 100, 255);
            RowsCellSelectionForeColor = Color.FromArgb(255, 255, 255);
            #endregion

            #region Setting Button Colors
            LightButtonBackColor = Color.FromArgb(3, 2, 19);
            LightButtonForeColor = Color.FromArgb(255, 255, 255);
            LightButtonHoverColor = Color.FromArgb(28, 27, 43);
            DarkButtonBackColor = Color.FromArgb(255, 255, 255);
            DarkButtonForeColor = Color.FromArgb(10, 10, 10);
            DarkButtonHoverColor = Color.FromArgb(233, 235, 239);
            #endregion

            #region Text Box Colors
            TextBoxBackColor = Color.FromArgb(250, 250, 250);
            TextBoxForeColor = Color.FromArgb(10, 10, 10);
            #endregion

            #region Common Colors
            CancelButtonBackColor = Color.FromArgb(250, 250, 250);
            CancelButtonForeColor = Color.FromArgb(10, 10, 10);
            SaveButtonBackColor = Color.FromArgb(10, 10, 10);
            SaveButtonForeColor = Color.FromArgb(250, 250, 250);
            DisableSaveButtonForeColor = Color.FromArgb(150, 150, 150);
            PayButtonBackColor = Color.FromArgb(10, 10, 10);
            PayButtonForeColor = Color.FromArgb(250, 250, 250);
            #endregion

            #region Common Icons
            CloseIcon = Resources.Close_Black_20;
            DateTimeIcon = Resources.Time_Black_20;
            SaveIcon = Resources.Save_White_20;
            CancelIcon = Resources.Cancel_Black_20;
            SearchIcon = Resources.Search_White_20;
            PayIcon = Resources.Pay_White_20;
            #endregion

            #region Menu Icons
            DashboardIcon = Resources.Dashboard_Black_20;
            AppointmentsIcon = Resources.Appointment_Black_20;
            PatientsIcon = Resources.Patient_Black_20;
            DoctorsIcon = Resources.Doctor_Black_20;
            UsersIcon = Resources.Users_Black_20;
            DailyReportIcon = Resources.Report_Black_20;
            SettingsIcon = Resources.Settings_Black_20;
            #endregion

            #region Selected Menu Icons
            SelectedDashboardIcon = Resources.Dashboard_White_20;
            SelectedAppointmentsIcon = Resources.Appointment_White_20;
            SelectedPatientsIcon = Resources.Patient_White_20;
            SelectedDoctorsIcon = Resources.Doctor_White_20;
            SelectedUsersIcon = Resources.Users_White_20;
            SelectedDailyReportIcon = Resources.Report_White_20;
            SelectedSettingsIcon = Resources.Settings_White_20;
            #endregion

            #region Appointment Screen Icons
            AddAppointmentIconButton = Resources.Add_Appointment_White_20;
            AddAppointmentIcon = Resources.Add_Appointment_Black_20;
            TodaysAppointmnetIcon = Resources.Appointment_Black_20;
            PendingAppointmentIcon = Resources.Time_Black_20;
            InProgressAppointmentIcon = Resources.In_Progress_Black_20;
            CompletedAppointmentIcon = Resources.Completed_Appointment_Black_20;
            CompletedAppointmentItemIcon = Resources.Completed_Appointment_Black_20;
            PaymentsIcon = Resources.Payment_Black_20;
            CancelledAppointmentIcon = Resources.Cancel_Appointment_Black_20;
            EditAppointmnetIcon = Resources.Edit_Appointment_Black_20;
            #endregion

            #region Doctor Screen Icons
            AddDoctorButtonIcon = Resources.Add_Doctor_White_20;
            AddDoctorIcon = Resources.Add_Doctor_Black_20;
            EditDoctorIcon = Resources.Edit_Doctor_Black_20;
            DeleteDoctorIcon = Resources.Delete_Doctor_Black_20;
            #endregion

            #region Setting Screen Icons
            LightButtonIcon = Resources.Light_Mode_White_20;
            DarkButtonIcon = Resources.Dark_Mode_Black_20;
            AppearanceIcon = Resources.Appearance_Black_20;
            #endregion

            #region Patient Screen Icons
            AddPatientButtonIcon = Resources.Add_Patient_White_20;
            #endregion

            #region Daily Report Screen Icons
            GenerateDailyReportButtonIcon = Resources.Daily_Report_White_20;
            #endregion
        }
    }
}
