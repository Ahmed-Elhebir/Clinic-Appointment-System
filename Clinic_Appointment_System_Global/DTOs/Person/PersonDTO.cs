using System;
using System.Collections.Generic;
using System.Linq;


namespace Clinic_Appointment_System_Global.DTOs
{
    public class PersonDTO
    {
        public int PersonID { get; set; }
        public string NationalNo { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }

        public string FullName => $"{FirstName} {SecondName} {ThirdName} {LastName}".Replace("  ", " ").Trim();

        public GenderEnum Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int NationalityCountryID { get; set; }


        public PersonDTO(int personID, string nationalNo, string firstName, string secondName, string thirdName, string lastName, 
                GenderEnum gender, string phoneNumber, string email, DateTime dateOfBirth, int nationalityCountryID)
        {
            PersonID = personID;
            NationalNo = nationalNo;
            FirstName = firstName;
            SecondName = secondName;
            ThirdName = thirdName;
            LastName = lastName;
            Gender = gender;
            PhoneNumber = phoneNumber;
            Email = email;
            DateOfBirth = dateOfBirth;
            NationalityCountryID = nationalityCountryID;
        }
    }
}
