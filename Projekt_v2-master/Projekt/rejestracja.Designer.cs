
namespace Projekt
{
    partial class rejestracja
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
            this.rej_login = new System.Windows.Forms.TextBox();
            this.rej_haslo = new System.Windows.Forms.TextBox();
            this.rej_email = new System.Windows.Forms.TextBox();
            this.rej_phone = new System.Windows.Forms.TextBox();
            this.register = new System.Windows.Forms.Button();
            this.rej_zaloguj = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rej_conf_haslo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // rej_login
            // 
            this.rej_login.AcceptsTab = true;
            this.rej_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.rej_login.Location = new System.Drawing.Point(205, 36);
            this.rej_login.Name = "rej_login";
            this.rej_login.Size = new System.Drawing.Size(304, 32);
            this.rej_login.TabIndex = 1;
            // 
            // rej_haslo
            // 
            this.rej_haslo.AcceptsTab = true;
            this.rej_haslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.rej_haslo.Location = new System.Drawing.Point(205, 74);
            this.rej_haslo.Name = "rej_haslo";
            this.rej_haslo.PasswordChar = '*';
            this.rej_haslo.Size = new System.Drawing.Size(304, 32);
            this.rej_haslo.TabIndex = 2;
            // 
            // rej_email
            // 
            this.rej_email.AcceptsTab = true;
            this.rej_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.rej_email.Location = new System.Drawing.Point(205, 150);
            this.rej_email.Name = "rej_email";
            this.rej_email.Size = new System.Drawing.Size(304, 32);
            this.rej_email.TabIndex = 3;
            // 
            // rej_phone
            // 
            this.rej_phone.AcceptsTab = true;
            this.rej_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.rej_phone.Location = new System.Drawing.Point(205, 188);
            this.rej_phone.Name = "rej_phone";
            this.rej_phone.Size = new System.Drawing.Size(304, 32);
            this.rej_phone.TabIndex = 4;
            // 
            // register
            // 
            this.register.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.register.Location = new System.Drawing.Point(359, 301);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(150, 81);
            this.register.TabIndex = 8;
            this.register.Text = "Zarejestruj";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // rej_zaloguj
            // 
            this.rej_zaloguj.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.rej_zaloguj.Location = new System.Drawing.Point(205, 301);
            this.rej_zaloguj.Name = "rej_zaloguj";
            this.rej_zaloguj.Size = new System.Drawing.Size(150, 81);
            this.rej_zaloguj.TabIndex = 7;
            this.rej_zaloguj.Text = "Zaloguj";
            this.rej_zaloguj.UseVisualStyleBackColor = true;
            this.rej_zaloguj.Click += new System.EventHandler(this.rej_zaloguj_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(115, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "Login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(112, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "Hasło:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label3.Location = new System.Drawing.Point(108, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 26);
            this.label3.TabIndex = 11;
            this.label3.Text = "E-mail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label4.Location = new System.Drawing.Point(97, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 26);
            this.label4.TabIndex = 12;
            this.label4.Text = "Telefon:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label5.Location = new System.Drawing.Point(24, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 26);
            this.label5.TabIndex = 13;
            this.label5.Text = "Data urodzenia:";
            // 
            // rej_conf_haslo
            // 
            this.rej_conf_haslo.AcceptsTab = true;
            this.rej_conf_haslo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.rej_conf_haslo.Location = new System.Drawing.Point(205, 112);
            this.rej_conf_haslo.Name = "rej_conf_haslo";
            this.rej_conf_haslo.PasswordChar = '*';
            this.rej_conf_haslo.Size = new System.Drawing.Size(304, 32);
            this.rej_conf_haslo.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label6.Location = new System.Drawing.Point(14, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(172, 26);
            this.label6.TabIndex = 15;
            this.label6.Text = "Potwierdź hasło:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.dateTimePicker1.Location = new System.Drawing.Point(205, 226);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(304, 32);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // rejestracja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 397);
            this.ControlBox = false;
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rej_conf_haslo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.register);
            this.Controls.Add(this.rej_zaloguj);
            this.Controls.Add(this.rej_phone);
            this.Controls.Add(this.rej_email);
            this.Controls.Add(this.rej_haslo);
            this.Controls.Add(this.rej_login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "rejestracja";
            this.Text = "rejestracja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox rej_login;
        private System.Windows.Forms.TextBox rej_haslo;
        private System.Windows.Forms.TextBox rej_email;
        private System.Windows.Forms.TextBox rej_phone;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.Button rej_zaloguj;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox rej_conf_haslo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}