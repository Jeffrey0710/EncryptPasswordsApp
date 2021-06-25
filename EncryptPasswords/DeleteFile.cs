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
    public partial class DeleteFile : Form
    {
        public DeleteFile()
        {
            InitializeComponent();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string data;
            Boolean find = false;
            char[] separate = { '|' };
            String[] array = new string[3];

            StreamReader lect = File.OpenText("InfoFile.txt");
            StreamWriter temp = File.AppendText("Temporary.txt");

            data = lect.ReadLine();

            while (data != null)
            {
                array = data.Split(separate);

                if (array[0].Trim().Equals(TxtSite.Text) & array[1].Trim().Equals(TxtUser.Text))
                {
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

            if (find == false)
            {
                MessageBox.Show("Error. Site and User not find");
            }
            else if (find == true)
            {
                MessageBox.Show("Successfully deleted");
            }

            lect.Close();
            temp.Close();

            TxtSite.Clear();
            TxtUser.Clear();

            File.Delete("InfoFile.txt");
            File.Move("Temporary.txt", "InfoFile.txt");
        }
        
    }
}
