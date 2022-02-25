using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Login_Form.Classes
{
    public static class GlobalMethods
    {
        public static string encryptPassword(string password)
        {
            MD5CryptoServiceProvider md5Hash = new MD5CryptoServiceProvider();

            byte[] encrypt;

            UTF8Encoding encode = new UTF8Encoding();
            encrypt = md5Hash.ComputeHash(encode.GetBytes(password));

            StringBuilder encryptdata = new StringBuilder();
             
            for (int i = 0; i < encrypt.Length; i++)
            {
                encryptdata.Append(encrypt[i].ToString());
            }

            GlobalVariables.password = encryptdata.ToString();
            return encryptdata.ToString();
        }


        public static string randomPassword(int length)
        {
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789@#/.!')";
            var stringChars = new char[length];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString = new String(stringChars);
            return finalString;
        }
    }
}
