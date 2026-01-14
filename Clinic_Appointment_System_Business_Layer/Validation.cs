using System.Linq;
using System.Net.Mail;

namespace Clinic_Appointment_System_Business_Layer
{
    public class Validation
    {
        public static bool IsValidEmail(string email)
        {
            try
            {
                MailAddress addr = new MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            if (string.IsNullOrWhiteSpace(phoneNumber))
                return false;
            // Simple check: phone number should be 10 digits long
            var digits = new string(phoneNumber.Where(char.IsDigit).ToArray());
            return digits.Length == 10;
        }

        public static bool IsValidNationalNumber(string nationalNumber)
        {
            if (string.IsNullOrWhiteSpace(nationalNumber))
                return false;

            // Simple check: national ID should be 10 digits long
            var digits = new string(nationalNumber.Where(char.IsDigit).ToArray());
            return digits.Length == 10;
        }


    }
}
