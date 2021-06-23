using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EncryptPasswords
{
    public partial class Master : Form
    {
        public Master()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            string data;
            Boolean find = false;
            char[] separate = { '|' };
            String[] array = new string[3];

            StreamWriter info = File.AppendText("InfoFile.txt");

            info.Write(txtSite.Text + "|");
            info.Write(txtUser.Text + "|");
            info.Write(txtPassword.Text + "|");
            info.WriteLine();
            info.Close();

            StreamWriter temp = File.AppendText("Temporary.txt");
            StreamReader lect = File.OpenText("InfoFile.txt");

            data = lect.ReadLine();

            while(data != null)
            {
                array = data.Split(separate);

                if (array[0].Trim().Equals(txtSite.Text) & array[1].Trim().Equals(txtUser.Text))
                {
                    temp.Write(txtSite.Text + "|");
                    temp.Write(txtUser.Text + "|");
                    temp.Write(txtPassword.Text + "|");
                    temp.WriteLine();
                    find = true;
                }
                else
                {
                    temp.Write(array[0].Trim() + "|");
                    temp.Write(array[1].Trim() + "|");
                    temp.Write(array[2].Trim() + "|");
                    temp.WriteLine();
                }
                data = lect.ReadLine();
            }

            if(find == false)
            {
                MessageBox.Show("Data not inserted");
            }
            else if(find == true)
            {
                MessageBox.Show("Data inserted");
            }

            lect.Close();
            temp.Close();

            txtSite.Clear();
            txtUser.Clear();
            txtPassword.Clear();

            File.Delete("InfoFile.txt");
            File.Move("Temporary.txt", "InfoFile.txt");
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            String data;
            Boolean find = false;
            char[] separate = { '|' };
            string[] array = new string[3];

            StreamReader lect = File.OpenText("InfoFile.txt");
            data = lect.ReadLine();

            while(data != null)
            {
                array = data.Split(separate);

                if (array[0].Trim().Equals(txtSite.Text) & array[1].Trim().Equals(txtUser.Text))
                {
                    txtUncryptPass.Text = array[2].Trim();
                    find = true;
                }
                data = lect.ReadLine();
            }

            lect.Close();
            txtSite.Clear();
            txtUser.Clear();
        }
    }
}
