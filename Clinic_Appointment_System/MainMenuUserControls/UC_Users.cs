using System;
using System.Windows.Forms;

namespace Clinic_Appointment_System.UserControls
{
    public partial class UC_Users : UserControl
    {
        public UC_Users()
        {
            InitializeComponent();
            UC_Settings.OnSettingsChanged += ThemeChanged;
        }

        private void ThemeChanged(object sender, SettingsEventArgs e)
        {
            ApplyTheme();
        }

        private void ApplyTheme()
        {
            SetColor();
            SetIcons();
        }
        private void SetColor()
        {
            this.BackColor = ThemeColors.MainBackground;
            lblCommingSoon.ForeColor = ThemeColors.MainLabelText;
        }

        private void SetIcons()
        {
        }

        private void UC_Users_Load(object sender, EventArgs e)
        {
            ApplyTheme();
        }
    }
}
