
namespace Projekt
{
    partial class Admin_Panel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Panel));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Wypozycz = new System.Windows.Forms.Button();
            this.ksiazki = new System.Windows.Forms.Button();
            this.wyloguj = new System.Windows.Forms.Button();
            this.czytelnicy = new System.Windows.Forms.Button();
            this.zwroc = new System.Windows.Forms.Button();
            this.pracownicy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(216, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(358, 189);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // Wypozycz
            // 
            this.Wypozycz.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.Wypozycz.Location = new System.Drawing.Point(31, 12);
            this.Wypozycz.Name = "Wypozycz";
            this.Wypozycz.Size = new System.Drawing.Size(137, 61);
            this.Wypozycz.TabIndex = 15;
            this.Wypozycz.Text = "Wypożycz";
            this.Wypozycz.UseVisualStyleBackColor = true;
            this.Wypozycz.Click += new System.EventHandler(this.Wypozycz_Click);
            // 
            // ksiazki
            // 
            this.ksiazki.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.ksiazki.Location = new System.Drawing.Point(31, 146);
            this.ksiazki.Name = "ksiazki";
            this.ksiazki.Size = new System.Drawing.Size(137, 55);
            this.ksiazki.TabIndex = 16;
            this.ksiazki.Text = "Książki";
            this.ksiazki.UseVisualStyleBackColor = true;
            this.ksiazki.Click += new System.EventHandler(this.ksiazki_Click);
            // 
            // wyloguj
            // 
            this.wyloguj.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.wyloguj.Location = new System.Drawing.Point(616, 156);
            this.wyloguj.Name = "wyloguj";
            this.wyloguj.Size = new System.Drawing.Size(137, 45);
            this.wyloguj.TabIndex = 18;
            this.wyloguj.Text = "Wyloguj";
            this.wyloguj.UseVisualStyleBackColor = true;
            this.wyloguj.Click += new System.EventHandler(this.wyloguj_Click);
            // 
            // czytelnicy
            // 
            this.czytelnicy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.czytelnicy.Location = new System.Drawing.Point(616, 12);
            this.czytelnicy.Name = "czytelnicy";
            this.czytelnicy.Size = new System.Drawing.Size(137, 71);
            this.czytelnicy.TabIndex = 17;
            this.czytelnicy.Text = "Lista Czytelników";
            this.czytelnicy.UseVisualStyleBackColor = true;
            this.czytelnicy.Click += new System.EventHandler(this.czytelnicy_Click);
            // 
            // zwroc
            // 
            this.zwroc.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.zwroc.Location = new System.Drawing.Point(31, 79);
            this.zwroc.Name = "zwroc";
            this.zwroc.Size = new System.Drawing.Size(137, 61);
            this.zwroc.TabIndex = 19;
            this.zwroc.Text = "Zwróć";
            this.zwroc.UseVisualStyleBackColor = true;
            this.zwroc.Click += new System.EventHandler(this.zwroc_Click);
            // 
            // pracownicy
            // 
            this.pracownicy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.pracownicy.Location = new System.Drawing.Point(616, 89);
            this.pracownicy.Name = "pracownicy";
            this.pracownicy.Size = new System.Drawing.Size(137, 61);
            this.pracownicy.TabIndex = 20;
            this.pracownicy.Text = "Pracownicy";
            this.pracownicy.UseVisualStyleBackColor = true;
            this.pracownicy.Click += new System.EventHandler(this.pracownicy_Click);
            // 
            // Admin_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.pracownicy);
            this.Controls.Add(this.zwroc);
            this.Controls.Add(this.wyloguj);
            this.Controls.Add(this.czytelnicy);
            this.Controls.Add(this.ksiazki);
            this.Controls.Add(this.Wypozycz);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Admin_Panel";
            this.Text = "Panel Administracyjny";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Wypozycz;
        private System.Windows.Forms.Button ksiazki;
        private System.Windows.Forms.Button wyloguj;
        private System.Windows.Forms.Button czytelnicy;
        private System.Windows.Forms.Button zwroc;
        private System.Windows.Forms.Button pracownicy;
    }
}