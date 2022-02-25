using Bunifu.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Form
{
    public partial class Main : Form
    {
        static Main _object;

        public static Main Instance
        {
            get
            {
                if (_object == null)
                {
                    _object = new Main();
                }
                return _object;
            }
        }

        public Panel Container
        {
            get { return ContentPanel; }
            set { ContentPanel = value; }
        }

        public Main()
        {
            InitializeComponent();
            this.Icon = Properties.Resources.Account;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            Image.Visible = false;
            ContentPanel.Visible = false;

            _object = this;

            if (!ContentPanel.Controls.Contains(Login.Instance))
            {
                ContentPanel.Controls.Add(Login.Instance);
                Login.Instance.Dock = DockStyle.Fill;
                Login.Instance.BringToFront();
            }

            else
            {
                Login.Instance.BringToFront();
            }
        }

        private async void Main_Shown(object sender, EventArgs e)
        {
            await Task.Delay(200);
            Image.Visible = true;
            ContentPanelTransition.ShowSync(ContentPanel);
        }
    }
}
