# **Login Form**
---

![OS](https://img.shields.io/badge/OS-_Windows-blue) ![C#](https://img.shields.io/badge/C%23-_v7.3-yellow) ![.Net](https://img.shields.io/badge/.Net-_v4.7.2-red) ![GitHub last commit](https://img.shields.io/github/last-commit/GAGreatProgrammer/Login-Form) ![GitHub](https://img.shields.io/github/license/GAGreatProgrammer/Login-Form?color=orange)

<br/>

The Login Form allows users to login to the application using a username and password. The form allows you to easily and quickly authorize both using a local account and using Google, Facebook or Twitter.

<br/>

## System Description
---

![Login Form](https://raw.githubusercontent.com/GAGreatProgrammer/Login-Form/master/Login%20Form/Assets/Login.PNG)

The login form is an authorization template that allows users to log in to the system. The template consists of a main form and a subform. The form allows you to register a new user, as well as reset the password of an existing user. Also, for security, the function of two-factor authentication is used.

The form can be easily embedded into any project that needs a user login form. The form allows you to use any user data storage system.

<br/>


## System specifications
---

Login Form includes:

* Authorization Form
* Registration Form
* Reset Password Form
* Two-Factor Authentication Form

<br/>

## Form Properties
---

Settings are used to make the "Remember me" function work.

```csharp
<userSettings>
        <Login_Form.Properties.Settings>
            <setting name="Username" serializeAs="String">
                <value />
            </setting>
        </Login_Form.Properties.Settings>
    </userSettings>
```

<br/>

## Password Encryption
---

The following function is used to encrypt the password:

```csharp
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
```

<br/>

## Random Password
---

The following function is used to generate a random password:

```csharp
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
```

<br/>

## Global Variables
---

In the login form, the `Global Variables` class is used to store user data. Here you can store both authorization data and data of newly registered users.

```csharp
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


        //Recover Password
        public static string recover_UserName { get; set; }
        public static string recover_Password { get; set; }
        public static string recover_Email { get; set; }
        public static string recover_AdditionalInfo { get; set; }
    }
```

<br/>

## Conclusion
---
The login form template is suitable for small projects that need a quick and easy user login system. The form provides a simple template that is easily scalable and allows you to build in all the features you need.
