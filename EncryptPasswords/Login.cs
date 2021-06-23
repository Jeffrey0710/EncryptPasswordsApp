using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EncryptPasswords
{
    public partial class Login : Form
    {
        string user = "test";
        string pass = "test";

        public Login()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if(TxtUser.Text != user || TxtPassword.Text != pass)
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
                Close();
            }
        }
    }
}
