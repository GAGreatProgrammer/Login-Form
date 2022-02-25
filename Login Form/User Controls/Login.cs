using Login_Form.Classes;
using Login_Form.User_Controls;
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
    public partial class Login : UserControl
    {
        private static Login _instance;

        public static Login Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Login();
                return _instance;
            }
        }
        public Login()
        {
            InitializeComponent();
        }

        private void lblUserRegistration_Click(object sender, EventArgs e)
        {
            if (!Main.Instance.Container.Controls.ContainsKey("CreateNewAccount"))
            {
                CreateNewAccount createNewAccount = new CreateNewAccount();
                createNewAccount.Dock = DockStyle.Fill;
                Main.Instance.Container.Controls.Add(createNewAccount);
            }

            Main.Instance.Container.Controls["CreateNewAccount"].BringToFront();
        }

        private void lblForgotPasword_Click(object sender, EventArgs e)
        {
            if (!Main.Instance.Container.Controls.ContainsKey("RecoverPassword"))
            {
                RecoverPassword recoverPassword = new RecoverPassword();
                recoverPassword.Dock = DockStyle.Fill;
                Main.Instance.Container.Controls.Add(recoverPassword);
            }

            Main.Instance.Container.Controls["RecoverPassword"].BringToFront();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void storeData()
        {
            GlobalVariables.userName = txtUsername.Text;
            GlobalVariables.password = txtPassword.Text;
        }

        private void CheckStatus()
        {
            if (cbRememberMe.Checked == true)
            {
                Properties.Settings.Default.Username = txtUsername.Text;
                Properties.Settings.Default.Save();
            }
            else if (cbRememberMe.Checked == false)
            {
                Properties.Settings.Default.Username = "";
                Properties.Settings.Default.Save();
            }
        }

        private void cbRememberMe_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            CheckStatus();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Username != "")
            {
                txtUsername.Text = Properties.Settings.Default.Username;
                cbRememberMe.Checked = true;
            }
            else
            {
                txtUsername.Text = "";
                cbRememberMe.Checked = false;
            }

        }

        private async void btnLogin_Click_1(object sender, EventArgs e)
        {
            storeData();
            CheckStatus();
            Main.Instance.Hide();
            AccountAuthenticator accountAuthenticator = new AccountAuthenticator();
            await Task.Delay(200);
            accountAuthenticator.ShowDialog();
        }
    }
}
