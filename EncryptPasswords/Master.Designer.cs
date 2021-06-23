namespace EncryptPasswords
{
    partial class Master
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnEncrypt = new System.Windows.Forms.Button();
            this.BtnUncrypt = new System.Windows.Forms.Button();
            this.TxtSite = new System.Windows.Forms.TextBox();
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtUncryptPass = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnOpenFile = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label2.Location = new System.Drawing.Point(15, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Site";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label3.Location = new System.Drawing.Point(193, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "User";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Console", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label4.Location = new System.Drawing.Point(370, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // BtnEncrypt
            // 
            this.BtnEncrypt.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnEncrypt.FlatAppearance.BorderColor = System.Drawing.Color.SlateGray;
            this.BtnEncrypt.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BtnEncrypt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnEncrypt.Location = new System.Drawing.Point(597, 123);
            this.BtnEncrypt.Name = "BtnEncrypt";
            this.BtnEncrypt.Size = new System.Drawing.Size(120, 40);
            this.BtnEncrypt.TabIndex = 4;
            this.BtnEncrypt.Text = "Encrypt";
            this.BtnEncrypt.UseVisualStyleBackColor = false;
            this.BtnEncrypt.Click += new System.EventHandler(this.BtnEncrypt_Click);
            // 
            // BtnUncrypt
            // 
            this.BtnUncrypt.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnUncrypt.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BtnUncrypt.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnUncrypt.Location = new System.Drawing.Point(597, 331);
            this.BtnUncrypt.Name = "BtnUncrypt";
            this.BtnUncrypt.Size = new System.Drawing.Size(120, 40);
            this.BtnUncrypt.TabIndex = 5;
            this.BtnUncrypt.Text = "Uncrypt";
            this.BtnUncrypt.UseVisualStyleBackColor = false;
            this.BtnUncrypt.Click += new System.EventHandler(this.BtnUncrypt_Click);
            // 
            // TxtSite
            // 
            this.TxtSite.Location = new System.Drawing.Point(12, 133);
            this.TxtSite.Name = "TxtSite";
            this.TxtSite.Size = new System.Drawing.Size(150, 21);
            this.TxtSite.TabIndex = 6;
            this.TxtSite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtUser
            // 
            this.TxtUser.Location = new System.Drawing.Point(190, 133);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(150, 21);
            this.TxtUser.TabIndex = 7;
            this.TxtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtPassword
            // 
            this.TxtPassword.Location = new System.Drawing.Point(367, 133);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(200, 21);
            this.TxtPassword.TabIndex = 8;
            this.TxtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TxtUncryptPass
            // 
            this.TxtUncryptPass.Location = new System.Drawing.Point(12, 341);
            this.TxtUncryptPass.Name = "TxtUncryptPass";
            this.TxtUncryptPass.Size = new System.Drawing.Size(555, 21);
            this.TxtUncryptPass.TabIndex = 9;
            this.TxtUncryptPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BtnSave
            // 
            this.BtnSave.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnSave.Font = new System.Drawing.Font("Lucida Console", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BtnSave.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnSave.Location = new System.Drawing.Point(446, 219);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(150, 50);
            this.BtnSave.TabIndex = 10;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnOpenFile
            // 
            this.BtnOpenFile.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnOpenFile.Font = new System.Drawing.Font("Lucida Console", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BtnOpenFile.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnOpenFile.Location = new System.Drawing.Point(305, 403);
            this.BtnOpenFile.Name = "BtnOpenFile";
            this.BtnOpenFile.Size = new System.Drawing.Size(150, 50);
            this.BtnOpenFile.TabIndex = 11;
            this.BtnOpenFile.Text = "Open File";
            this.BtnOpenFile.UseVisualStyleBackColor = false;
            this.BtnOpenFile.Click += new System.EventHandler(this.BtnOpenFile_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Console", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.label5.Location = new System.Drawing.Point(15, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Uncrypt Password";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Goldenrod;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Lucida Console", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(-2, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(765, 60);
            this.label6.TabIndex = 13;
            this.label6.Text = "Encrypt Passwords";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnSearch
            // 
            this.BtnSearch.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnSearch.Font = new System.Drawing.Font("Lucida Console", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.BtnSearch.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.BtnSearch.Location = new System.Drawing.Point(163, 219);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(150, 50);
            this.BtnSearch.TabIndex = 14;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = false;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(760, 485);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnOpenFile);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.TxtUncryptPass);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.TxtUser);
            this.Controls.Add(this.TxtSite);
            this.Controls.Add(this.BtnUncrypt);
            this.Controls.Add(this.BtnEncrypt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Master";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encrypt Passwords";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnEncrypt;
        private System.Windows.Forms.Button BtnUncrypt;
        private System.Windows.Forms.TextBox TxtSite;
        private System.Windows.Forms.TextBox TxtUser;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtUncryptPass;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnOpenFile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BtnSearch;
    }
}

