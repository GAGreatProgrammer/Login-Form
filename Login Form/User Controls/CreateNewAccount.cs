using Login_Form.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Form
{
    public partial class CreateNewAccount : UserControl
    {
        private static CreateNewAccount _instance;

        public static CreateNewAccount Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new CreateNewAccount();
                return _instance;
            }
        }
        public CreateNewAccount()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (!Main.Instance.Container.Controls.ContainsKey("Login"))
            {
                CreateNewAccount createNewAccount = new CreateNewAccount();
                createNewAccount.Dock = DockStyle.Fill;
                Main.Instance.Container.Controls.Add(createNewAccount);
            }

            Main.Instance.Container.Controls["Login"].BringToFront();
        }

        private void storeData()
        {
            GlobalVariables.firstName = txtFirstName.Text;
            GlobalVariables.lastName = txtLastName.Text;
            GlobalVariables.birthDate = txtBirthDate.Text;
            GlobalVariables.country = txtCountry.Text;
            GlobalVariables.telephone = txtTelephone.Text;
            GlobalVariables.email = txtEmail.Text;
            GlobalVariables.newUserName = txtUsername.Text;
            GlobalVariables.newPassword = txtPassword.Text;
        }

        private void btnCreateAccount_Click_1(object sender, EventArgs e)
        {
            storeData();
        }

        private void btnGeneratePassword_Click_1(object sender, EventArgs e)
        {
            string pasword = GlobalMethods.randomPassword(15);

            txtPassword.Text = pasword;
            txtConfirmPassword.Text = pasword;
        }
    }
}
