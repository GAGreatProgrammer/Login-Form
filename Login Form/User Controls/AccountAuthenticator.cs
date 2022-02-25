using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Form.User_Controls
{
    public partial class AccountAuthenticator : Form
    {
        public AccountAuthenticator()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.Account;
        }

        private void AccountAuthenticator_Load(object sender, EventArgs e)
        {
            Card.Visible = false;
            ControlsStatus();
        }

        private void ControlsStatus()
        {
            txt1.Enabled = true;
            txt1.Focus();
            txt2.Enabled = false;
            txt3.Enabled = false;
            txt4.Enabled = false;
            txt5.Enabled = false;
            btnSubmit.Enabled = false;
            btnSubmit.Text = "5 Digits Left";
        }


        private void AccountAuthenticator_Shown(object sender, EventArgs e)
        {
            MainTransition.ShowSync(Card);
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {
            if (txt1.Text.Length == 1)
            {
                txt1.Enabled = false;
                txt2.Enabled = true;
                txt2.Focus();
                btnSubmit.Text = "4 Digits Left";
            }
        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {
            if (txt2.Text.Length == 1)
            {
                txt2.Enabled = false;
                txt3.Enabled = true;
                txt3.Focus();
                btnSubmit.Text = "3 Digits Left";
            }
        }

        private void txt3_TextChanged(object sender, EventArgs e)
        {
            if (txt3.Text.Length == 1)
            {
                txt3.Enabled = false;
                txt4.Enabled = true;
                txt4.Focus();
                btnSubmit.Text = "2 Digits Left";
            }
        }

        private void txt4_TextChanged(object sender, EventArgs e)
        {
            if (txt4.Text.Length == 1)
            {
                txt4.Enabled = false;
                txt5.Enabled = true;
                txt5.Focus();
                btnSubmit.Text = "1 Digits Left";
            }
        }

        private void txt5_TextChanged(object sender, EventArgs e)
        {
            if (txt5.Text.Length == 1)
            {
                txt5.Enabled = false;
                btnSubmit.Enabled = true;
                btnSubmit.Focus();
                btnSubmit.Text = "Submit";
            }
        }

        private async void btnSubmit_Click_1(object sender, EventArgs e)
        {
            Main.Instance.Show();
            await Task.Delay(200);
            this.Close();
        }
    }
}
