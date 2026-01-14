
namespace Clinic_Appointment_System_Global.DTOs.Patient
{
    public class PatientListDTO
    {
        public int PatientID { get; set; }
        public string FullName { get; set; }
        public byte Age { get; set; }
        public string FileNo { get; set; }
        public string NationalNo { get; set; }
        public string Gender { get; set; }
        public string Nationality { get; set; }


        public PatientListDTO(int patientID, string fullName, byte age, string fileNo, string nationalNo,
            string gender, string nationality)
        {
            PatientID = patientID;
            FullName = fullName;
            Age = age;
            FileNo = fileNo;
            NationalNo = nationalNo;
            Gender = gender;
            Nationality = nationality;
        }
    }
}
