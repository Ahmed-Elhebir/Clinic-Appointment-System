
namespace Clinic_Appointment_System_Global.DTOs.Doctor
{
    public class DoctorListDTO
    {
        public int DoctorID { get; set; }
        public string FullName { get; set; }
        public string SpecialtyName { get; set; }
        public byte Age { get; set; }
        public string Gender { get; set; }
        public string CountryName { get; set; }
        public string NationalNo { get; set; }


        public DoctorListDTO(int doctorID, string fullName, string specialtyName, byte age,
            string gender, string countryName, string nationalNo)
        {
            DoctorID = doctorID;
            FullName = fullName;
            SpecialtyName = specialtyName;
            Age = age;
            NationalNo = nationalNo;
            Gender = gender;
            CountryName = countryName;
        }
    }
}
