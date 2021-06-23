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
    public partial class DataFile : Form
    {
        public DataFile()
        {
            InitializeComponent();
        }

        private void BtnOpen_Click(object sender, EventArgs e)
        {
            string ubi = @"C:\Users\Jeffrey\source\repos\EncryptPasswordsApp\EncryptPasswords\bin\Debug\InfoFile.txt";

            string readFile = File.ReadAllText(ubi);
            TxtData.Text = readFile;
        }
    }
}
