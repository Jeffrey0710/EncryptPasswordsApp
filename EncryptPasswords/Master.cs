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
using System.Security.Cryptography;

namespace EncryptPasswords
{
    public partial class Master : Form
    {
        public static string KeyCode = "gkft93uif43hu514";

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

            info.Write(TxtSite.Text + "|");
            info.Write(TxtUser.Text + "|");
            info.Write(TxtPassword.Text + "|");
            info.WriteLine();
            info.Close();

            StreamWriter temp = File.AppendText("Temporary.txt");
            StreamReader lect = File.OpenText("InfoFile.txt");

            data = lect.ReadLine();

            while(data != null)
            {
                array = data.Split(separate);

                if (array[0].Trim().Equals(TxtSite.Text) & array[1].Trim().Equals(TxtUser.Text))
                {
                    temp.Write(TxtSite.Text + "|");
                    temp.Write(TxtUser.Text + "|");
                    temp.Write(TxtPassword.Text + "|");
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

            TxtSite.Clear();
            TxtUser.Clear();
            TxtPassword.Clear();

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

                if (array[0].Trim().Equals(TxtSite.Text) & array[1].Trim().Equals(TxtUser.Text))
                {
                    TxtUncryptPass.Text = array[2].Trim();
                    find = true;
                }
                data = lect.ReadLine();
            }

            lect.Close();
            TxtSite.Clear();
            TxtUser.Clear();
        }

        public string Encrypt(string pass, string pkey) 
        {
            byte[] keyArray;
            byte[] passEncrypt = Encoding.UTF8.GetBytes(pass); 

            keyArray = Encoding.UTF8.GetBytes(pkey);   

            var tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateEncryptor();
            byte[] result = cTransform.TransformFinalBlock(passEncrypt, 0, passEncrypt.Length);
            tdes.Clear();

            return Convert.ToBase64String(result, 0, result.Length);
        }

        public string Uncrypt(string pass, string pkey)
        {
            byte[] keyArray;
            byte[] passUncrypt = Convert.FromBase64String(pass);

            keyArray = Encoding.UTF8.GetBytes(pkey);  

            var tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateDecryptor();
            byte[] result = cTransform.TransformFinalBlock(passUncrypt, 0, passUncrypt.Length); 
            tdes.Clear();

            return Encoding.UTF8.GetString(result);
        }

        private void BtnEncrypt_Click(object sender, EventArgs e)
        {
            TxtPassword.Text = Encrypt(TxtPassword.Text, KeyCode);
        }

        private void BtnUncrypt_Click(object sender, EventArgs e)
        {
            TxtUncryptPass.Text = Uncrypt(TxtUncryptPass.Text, KeyCode);
        }

        private void BtnOpenFile_Click(object sender, EventArgs e)
        {
            
        }
    }
}
