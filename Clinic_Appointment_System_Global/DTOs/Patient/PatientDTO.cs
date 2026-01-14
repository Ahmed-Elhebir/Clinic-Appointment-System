
namespace Clinic_Appointment_System_Global.DTOs.Patient
{
    public class PatientDTO
    {
        public int PatientID { get; set; }
        public string FileNo { get; set; }
        public int PersonID { get; set; }
        public PersonDTO PersonDTO { get; set; }


        public PatientDTO(int patientID, string fileNo, int personID, PersonDTO personDTO)
        {
            PatientID = patientID;
            FileNo = fileNo;
            PersonID = personID;
            PersonDTO = personDTO;
        }
    
    }
}
