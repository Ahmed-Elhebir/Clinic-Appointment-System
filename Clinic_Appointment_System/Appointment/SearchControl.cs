using Clinic_Appointment_System.UserControls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Clinic_Appointment_System.Appointment
{
    public partial class SearchControl : UserControl
    {
        public event EventHandler<SearchEventArgs> OnSearch;
        
        public void RaiseOnSearch(string filterBy, string searchText)
        {
            RaiseOnSearch(new SearchEventArgs(filterBy, searchText));
        }

        public void RaiseOnSearch(SearchEventArgs e)
        {
            OnSearch?.Invoke(this, e);
        }

        public SearchControl()
        {
            InitializeComponent();
            Clear();
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
            gbFilter.BackColor = ThemeColors.MainBackground;
            gbFilter.ForeColor = ThemeColors.MainLabelText;
            gbDetails.BackColor = ThemeColors.MainBackground;
            gbDetails.ForeColor = ThemeColors.MainLabelText;
            lblSearchBy.ForeColor = ThemeColors.MainLabelText;

            #region TextBox Colors
            txtSearch.BackColor = ThemeColors.TextBoxBackColor;
            txtSearch.ForeColor = ThemeColors.TextBoxForeColor;
            #endregion

            #region Button Colors
            btnSearch.BackColor = ThemeColors.SecondaryButtonBackground;
            btnSearch.ForeColor = ThemeColors.SecondaryButtonForeground;
            #endregion

            #region Label Colors
            lblLine1.ForeColor = ThemeColors.MainLabelText;
            lblLine2.ForeColor = ThemeColors.MainLabelText;
            #endregion
        }

        private void SetIcons()
        {
            btnSearch.Image = ThemeColors.SearchIcon;
        }

        public void Clear()
        {
            txtSearch.Clear();
            lblLine1.Text = "";
            lblLine2.Text = "";
            lblLine1.Visible = false;
            lblLine2.Visible = false;
            if (cbSearch.Items.Count > 0)
                cbSearch.SelectedIndex = 0;

        }

        public void SetFilterOptions(List<string> options)
        {
            cbSearch.DataSource = options;
            if (cbSearch.Items.Count > 0)
                cbSearch.SelectedIndex = 0;
        }

        public void DisplayResult(string line1, string line2)
        {
            lblLine1.Text = line1;
            lblLine2.Text = line2;
            lblLine1.Visible = true;
            lblLine2.Visible = true;
        }

        public void DisableControl()
        {
            cbSearch.Enabled = false;
            txtSearch.Enabled = false;
            btnSearch.Enabled = false;
        }

        public string SelectedFilter
        {
            get { return (cbSearch.SelectedValue?.ToString() ?? ""); }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearch.Text.Trim()))
            {
                MessageBox.Show("Please enter a text to search.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (OnSearch != null)
                RaiseOnSearch(SelectedFilter, txtSearch.Text.Trim());
        }

        public class SearchEventArgs : EventArgs
        {
            public string FilterBy { get; set; }
            public string SearchText { get; set; }

            public SearchEventArgs(string filterBy, string searchText)
            {
                FilterBy = filterBy;
                SearchText = searchText;
            }
        }

        private void SearchControl_Load(object sender, EventArgs e)
        {
            ApplyTheme();
        }

        private void btnSearch_EnabledChanged(object sender, EventArgs e)
        {
            btnSearch.ForeColor = btnSearch.Enabled ? ThemeColors.SecondaryButtonForeground : ThemeColors.DisableSaveButtonForeColor;
        }

        private void btnSearch_Paint(object sender, PaintEventArgs e)
        {
            if (!btnSearch.Enabled)
            {
                TextFormatFlags flags = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter;
                TextRenderer.DrawText(e.Graphics, btnSearch.Text, btnSearch.Font, e.ClipRectangle, btnSearch.ForeColor, flags);
            }
        }
    }


}
