using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Form.Classes
{
    public static class GlobalVariables
    {
        //Login Form
        public static string userName { get; set; }
        public static string password { get; set; }



        //Account Registration Form
        public static string firstName { get; set; }
        public static string lastName { get; set; }
        public static string birthDate { get; set; }
        public static string country { get; set; }
        public static string telephone { get; set; }
        public static string email { get; set; }
        public static string newUserName { get; set; }
        public static string newPassword { get; set; }



        //RecoverPassword
        public static string recover_UserName { get; set; }
        public static string recover_Password { get; set; }
        public static string recover_Email { get; set; }
        public static string recover_AdditionalInfo { get; set; }
    }
}
