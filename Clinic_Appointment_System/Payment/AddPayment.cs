using Clinic_Appointment_System.UserControls;
using Clinic_Appointment_System_Business_Layer;
using Clinic_Appointment_System_Global;
using Clinic_Appointment_System_Global.Enums;
using System;
using System.Windows.Forms;

namespace Clinic_Appointment_System.Payment
{
    public partial class AddPayment : Form
    {
        private PaymentService _PaymentService = new PaymentService();
        private int _AppointmentID = -1;

        public AddPayment(int appointmentID)
        {
            InitializeComponent();
            _AppointmentID = appointmentID;
            cbPaymentMethod.DataSource = Enum.GetValues(typeof(PaymentMethodEnum));
            FormDragHelper.EnableDrag(this);
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
            pFullForm.BackColor = ThemeColors.MainBackground;
            pAppointmentDetails.BackColor = ThemeColors.MainBackground;
            pPaymentInfo.BackColor = ThemeColors.MainBackground;

            lblAddEditTitle.ForeColor = ThemeColors.MainLabelText;
            lblAppointmentDetails.ForeColor = ThemeColors.MainLabelText;
            lblID.ForeColor = ThemeColors.MainLabelText;
            lblAppointmentID.ForeColor = ThemeColors.MainLabelText;
            lblPatient.ForeColor = ThemeColors.MainLabelText;
            lblPatientName.ForeColor = ThemeColors.MainLabelText;
            lblDoctor.ForeColor = ThemeColors.MainLabelText;
            lblDoctorName.ForeColor = ThemeColors.MainLabelText;
            lblDate.ForeColor = ThemeColors.MainLabelText;
            lblDateTime.ForeColor = ThemeColors.MainLabelText;
            lblPaymentInfo.ForeColor = ThemeColors.MainLabelText;
            lblAmount.ForeColor = ThemeColors.MainLabelText;
            lblPaymentMethod.ForeColor = ThemeColors.MainLabelText;

            btnPay.BackColor = ThemeColors.PayButtonBackColor;
            btnPay.ForeColor = ThemeColors.PayButtonForeColor;
            btnCancel.BackColor = ThemeColors.CancelButtonBackColor;
            btnCancel.ForeColor = ThemeColors.CancelButtonForeColor;

        }

        private void SetIcons()
        {
            pbClose.Image = ThemeColors.CloseIcon;
            btnPay.Image = ThemeColors.PayIcon;
            btnCancel.Image = ThemeColors.CancelIcon;
        }

        private void AddPayment_Load(object sender, EventArgs e)
        {
            ApplyTheme();
            AppointmentService appointmentService = AppointmentService.FindByID(_AppointmentID);

            if (appointmentService == null)
            {
                MessageBox.Show("Couldn't find Appointment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            lblAppointmentID.Text = _AppointmentID.ToString();
            lblPatientName.Text = appointmentService.PatientFullName;
            lblDoctorName.Text = appointmentService.DoctorFullName;
            lblDateTime.Text = appointmentService.AppointmentDate.ToString("f");

            txtAmount.Text = "0.0";
            cbPaymentMethod.SelectedIndex = cbPaymentMethod.FindString(PaymentMethodEnum.Cash.ToString());

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtAmount.Text.Trim(), out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Please enter a valid amount.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _PaymentService.AppointmentID = _AppointmentID;
            _PaymentService.Amount = Convert.ToDecimal(txtAmount.Text.Trim());
            _PaymentService.PaymentMethod = (PaymentMethodEnum)cbPaymentMethod.SelectedIndex + 1;
            _PaymentService.PaymentDate = DateTime.Now;
            _PaymentService.UserID = CurrentUser.UserID;

            OperationResult result = _PaymentService.Save();

            if (result.Success)
            {
                MessageBox.Show(result.Message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show(result.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
