using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinic_Appointment_System_Data_Access_Layer;
using Clinic_Appointment_System_Global.DTOs.Country;

namespace Clinic_Appointment_System_Business_Layer
{
    public class CountryService
    {
        public static List<CountryDTO> GetAllCountries()
        {
            return CountryData.GetAllCountries();
        }

        public static CountryDTO FindByName(string countryName)
        {
            return CountryData.GetCountryByName(countryName);
        }

        public static CountryDTO FindByID(int countryID)
        {
            return CountryData.GetCountryByID(countryID);
        }
    }
}
