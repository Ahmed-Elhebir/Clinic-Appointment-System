using Clinic_Appointment_System_Data_Access_Layer;
using Clinic_Appointment_System_Global.DTOs.User;
using System.Security.Cryptography;
using System;
using System.Text;
using Clinic_Appointment_System_Global.DTOs;
using Clinic_Appointment_System_Global;

namespace Clinic_Appointment_System_Business_Layer
{
    public class UserService
    {
        private static readonly string encryptKey = "1234567890123456"; // 16 chars = 128 bits key

        public static UserDTO Find(string userName, string password)
        {
            string encryptedPassword = Encrypt(password, encryptKey);
            return UserData.GetUserByUserNameAndPassword(userName, encryptedPassword);
        }

        private static string Encrypt(string plainText, string key)
        {
            using (Aes aesAlg = Aes.Create())
            {
                // Set the key and IV for AES encryption
                aesAlg.Key = Encoding.UTF8.GetBytes(key);
                aesAlg.IV = new byte[aesAlg.BlockSize / 8]; // Initialize IV with zeros

                // Create an encyptor
                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                // Encrypt the data
                using (var msEncrypt = new System.IO.MemoryStream())
                {
                    using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    using (var swEncrypt = new System.IO.StreamWriter(csEncrypt))
                    {
                        swEncrypt.Write(plainText);
                    }
                    return Convert.ToBase64String(msEncrypt.ToArray());
                }
            }
        }

        private static string Decrypt(string cipherText, string key)
        {
            using (Aes aesAlg = Aes.Create())
            {
                // Set the key and IV for AES decryption
                aesAlg.Key = Encoding.UTF8.GetBytes(key);
                aesAlg.IV = new byte[aesAlg.BlockSize / 8]; // Initialize IV with zeros

                // Create a decryptor
                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                // Decrypt the data
                using (var msDecrypt = new System.IO.MemoryStream(Convert.FromBase64String(cipherText)))
                {
                    using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    using (var srDecrypt = new System.IO.StreamReader(csDecrypt))
                    {
                        return srDecrypt.ReadToEnd();
                    }
                }
            }
        }
        
    }
}
