
namespace Projekt
{
    partial class login_form
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.login_btn = new System.Windows.Forms.Button();
            this.register_btn = new System.Windows.Forms.Button();
            this.guest_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.exit_btn = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.TextBox();
            this.error_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // login_btn
            // 
            this.login_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.login_btn.Location = new System.Drawing.Point(145, 221);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(150, 81);
            this.login_btn.TabIndex = 2;
            this.login_btn.Text = "Zaloguj";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // register_btn
            // 
            this.register_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.register_btn.Location = new System.Drawing.Point(299, 221);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(150, 81);
            this.register_btn.TabIndex = 3;
            this.register_btn.Text = "Zarejestruj";
            this.register_btn.UseVisualStyleBackColor = true;
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // guest_btn
            // 
            this.guest_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.guest_btn.Location = new System.Drawing.Point(145, 308);
            this.guest_btn.Name = "guest_btn";
            this.guest_btn.Size = new System.Drawing.Size(150, 81);
            this.guest_btn.TabIndex = 4;
            this.guest_btn.Text = "Wejdź jako gość";
            this.guest_btn.UseVisualStyleBackColor = true;
            this.guest_btn.Click += new System.EventHandler(this.guest_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.Location = new System.Drawing.Point(262, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.Location = new System.Drawing.Point(259, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 26);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hasło:";
            // 
            // password
            // 
            this.password.AcceptsTab = true;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.password.Location = new System.Drawing.Point(142, 112);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(304, 32);
            this.password.TabIndex = 10;
            // 
            // exit_btn
            // 
            this.exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.exit_btn.Location = new System.Drawing.Point(301, 308);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(150, 81);
            this.exit_btn.TabIndex = 8;
            this.exit_btn.Text = "Wyjdź";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // login
            // 
            this.login.AcceptsTab = true;
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.login.Location = new System.Drawing.Point(145, 39);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(304, 32);
            this.login.TabIndex = 9;
            // 
            // error_label
            // 
            this.error_label.AutoSize = true;
            this.error_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.error_label.ForeColor = System.Drawing.Color.Red;
            this.error_label.Location = new System.Drawing.Point(173, 169);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(254, 20);
            this.error_label.TabIndex = 10;
            this.error_label.Text = "Login LUB Hasło jest niepoprawne";
            this.error_label.Visible = false;
            // 
            // login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 395);
            this.ControlBox = false;
            this.Controls.Add(this.error_label);
            this.Controls.Add(this.login);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guest_btn);
            this.Controls.Add(this.register_btn);
            this.Controls.Add(this.login_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Name = "login_form";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.Button guest_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.TextBox login;
        private System.Windows.Forms.Label error_label;
    }
}

