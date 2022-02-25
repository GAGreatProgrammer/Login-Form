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
    public partial class RecoverPassword : UserControl
    {
        private static RecoverPassword _instance;

        public static RecoverPassword Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new RecoverPassword();
                return _instance;
            }
        }
        public RecoverPassword()
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
            GlobalVariables.recover_UserName = txtUsername.Text;
            GlobalVariables.recover_Password = txtPassword.Text;
            GlobalVariables.recover_Email = txtEmail.Text;
            GlobalVariables.recover_AdditionalInfo = txtAdditionalInfo.Text;
        }

        private void btnRecoverPassword_Click_1(object sender, EventArgs e)
        {
            storeData();
        }
    }
}
