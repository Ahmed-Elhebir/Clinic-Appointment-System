using System;
using System.Windows.Forms;

namespace Clinic_Appointment_System.UserControls
{
    public partial class UC_Settings : UserControl
    {

        public static event EventHandler<SettingsEventArgs> OnSettingsChanged;

        private static bool _IsDark = false;

        public UC_Settings()
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
            SetColors();
            SetIcons();
        }

        private void SetColors()
        {
            this.BackColor = ThemeColors.MainBackground;
            pAppearance.BackColor = ThemeColors.MainBackground;

            lblTitle.ForeColor = ThemeColors.MainLabelText;
            lblAppearanceTitle.ForeColor = ThemeColors.MainLabelText;
            lblTheme.ForeColor = ThemeColors.MainLabelText;
            lblDescription.ForeColor = ThemeColors.SecondaryLabelText;

            btnLightMode.BackColor = ThemeColors.LightButtonBackColor;
            btnLightMode.ForeColor = ThemeColors.LightButtonForeColor;
            btnDarkMode.BackColor = ThemeColors.DarkButtonBackColor;
            btnDarkMode.ForeColor = ThemeColors.DarkButtonForeColor;

        }

        private void SetIcons()
        {
            pbAppearance.Image = ThemeColors.AppearanceIcon;
            btnLightMode.Image = ThemeColors.LightButtonIcon;
            btnDarkMode.Image = ThemeColors.DarkButtonIcon;
        }

        private void btnLightMode_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = ThemeColors.LightButtonHoverColor;
        }

        private void btnLightMode_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = ThemeColors.LightButtonBackColor;
        }

        private void btnDarkMode_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = ThemeColors.DarkButtonHoverColor;
        }

        private void btnDarkMode_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = ThemeColors.DarkButtonBackColor;
        }

        private void btnLightMode_Click(object sender, EventArgs e)
        {
            _IsDark = false;
            ThemeColors.ApplyTheme(_IsDark);
            OnSettingsChanged?.Invoke(this, new SettingsEventArgs(_IsDark));
        }

        private void btnDarkMode_Click(object sender, EventArgs e)
        {
            _IsDark = true;
            ThemeColors.ApplyTheme(_IsDark);
            OnSettingsChanged?.Invoke(this, new SettingsEventArgs(_IsDark));
        }

        private void UC_Settings_Load(object sender, EventArgs e)
        {
            ApplyTheme();
        }
    }

    public class SettingsEventArgs : EventArgs
    {
        public bool IsDarkMode { get; }

        public SettingsEventArgs(bool isDark)
        {
            this.IsDarkMode = isDark;
        }
    }
}
