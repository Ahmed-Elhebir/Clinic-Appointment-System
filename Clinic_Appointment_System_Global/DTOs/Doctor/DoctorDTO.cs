
namespace Clinic_Appointment_System_Global.DTOs.Doctor
{
    public class DoctorDTO
    {
        public int DoctorID { get; set; }
        public int SpecialtyID { get; set; }
        public int PersonId { get; set; }
        public PersonDTO PersonDTO { get; set; }


        public DoctorDTO(int doctorID, int specialtyID, int personID, PersonDTO personDTO)
        {
            DoctorID = doctorID;
            SpecialtyID = specialtyID;
            PersonId = personID;
            PersonDTO = personDTO;
        }
    }
}