namespace OgrenciAPP
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.btn_Giris = new System.Windows.Forms.Button();
            this.btn_Vazgec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.Location = new System.Drawing.Point(83, 63);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(70, 13);
            this.lbl_Username.TabIndex = 0;
            this.lbl_Username.Text = "Kullanıcı Adı :";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(110, 93);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(43, 13);
            this.lbl_Password.TabIndex = 1;
            this.lbl_Password.Text = "Parola :";
            // 
            // txt_Username
            // 
            this.txt_Username.Location = new System.Drawing.Point(171, 63);
            this.txt_Username.Name = "txt_Username";
            this.txt_Username.Size = new System.Drawing.Size(132, 20);
            this.txt_Username.TabIndex = 2;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(171, 93);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(132, 20);
            this.txt_Password.TabIndex = 3;
            // 
            // btn_Giris
            // 
            this.btn_Giris.Location = new System.Drawing.Point(256, 151);
            this.btn_Giris.Name = "btn_Giris";
            this.btn_Giris.Size = new System.Drawing.Size(75, 23);
            this.btn_Giris.TabIndex = 4;
            this.btn_Giris.Text = "&Giriş";
            this.btn_Giris.UseVisualStyleBackColor = true;
            this.btn_Giris.Click += new System.EventHandler(this.btn_Giris_Click);
            // 
            // btn_Vazgec
            // 
            this.btn_Vazgec.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Vazgec.Location = new System.Drawing.Point(152, 151);
            this.btn_Vazgec.Name = "btn_Vazgec";
            this.btn_Vazgec.Size = new System.Drawing.Size(75, 23);
            this.btn_Vazgec.TabIndex = 5;
            this.btn_Vazgec.Text = "&Vazgeç";
            this.btn_Vazgec.UseVisualStyleBackColor = true;
            this.btn_Vazgec.Click += new System.EventHandler(this.btn_Vazgec_Click);
            // 
            // LoginForm
            // 
            this.AcceptButton = this.btn_Giris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn_Vazgec;
            this.ClientSize = new System.Drawing.Size(381, 217);
            this.Controls.Add(this.btn_Vazgec);
            this.Controls.Add(this.btn_Giris);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Username);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.Button btn_Giris;
        private System.Windows.Forms.Button btn_Vazgec;
    }
}