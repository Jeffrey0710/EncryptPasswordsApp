using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace EncryptPasswords
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            var user = ConfigurationManager.AppSettings["dtUser"];
            var pass = ConfigurationManager.AppSettings["dtPass"];

            if (TxtUser.Text != user || TxtPassword.Text != pass)
            {
                if(TxtUser.Text != user)
                {
                    MessageBox.Show("Incorrect user");
                    TxtUser.Clear();
                    TxtUser.Focus();
                    return;
                }
                if(TxtPassword.Text != pass)
                {
                    MessageBox.Show("Incorrect password");
                    TxtPassword.Clear();
                    TxtPassword.Focus();
                    return;
                }
            }
            else
            {
                TxtUser.Clear();
                TxtPassword.Clear();
                Master formMaster = new Master();
                formMaster.ShowDialog();
                this.Hide();
            }
        }
    }
}
