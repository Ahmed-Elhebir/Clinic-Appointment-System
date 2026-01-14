
namespace Clinic_Appointment_System_Global.DTOs.User
{
    public class UserDTO
    {
        public int UserID { get; set; }
        public int PersonID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; } // Role can be "Admin", "Doctor", "Patient", "Receptionist".
        public bool IsActive { get; set; }
        public PersonDTO PersonDTO { get; set; }


        public UserDTO(int userID, int personID, string userName, string password, string role, bool isActive, PersonDTO personDTO)
        {
            UserID = userID;
            PersonID = personID;
            UserName = userName;
            Password = password;
            Role = role;
            IsActive = isActive;
            PersonDTO = personDTO;
        }
    }
}
