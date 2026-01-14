using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic_Appointment_System_Global.DTOs.Country
{
    public class CountryDTO
    {
        public int CountryID { get; set; }
        public string CountryName { get; set; }

        public CountryDTO(int countryID, string countryName)
        {
            this.CountryID = countryID;
            this.CountryName = countryName;
        }

    }
}
