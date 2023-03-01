using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt
{
    public partial class login_form : Form
    {


        public login_form()
        {
            InitializeComponent();
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            rejestracja rej = new rejestracja();
            rej.Show();
            this.Close();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guest_btn_Click(object sender, EventArgs e)
        {
            strona_glowna_guest main = new strona_glowna_guest();
            main.Show();
            this.Close();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            using (DaneEntities database = new DaneEntities())
            {
                var czytelnik = from user in database.Czytelnicy
                                where user.login == login.Text && user.haslo == password.Text
                                select new { user.id_czytelnik, user.login, user.haslo, user.email };


                var pracownik = from admin in database.Pracownicy
                                where admin.login == login.Text &&
                                      admin.haslo == password.Text
                                select new { admin.id_pracownik, admin.login, admin.haslo };

                if (pracownik.Any())
                {
                    Admin_Panel main = new Admin_Panel((long)pracownik.First().id_pracownik);
                    this.Close();
                    main.Show();
                    //TODO: Dialog "Zalogowano pomyślnie"
                    //main.ShowDialog();
                    login.Text = "";
                    password.Text = "";
                }
                else if (czytelnik.Any())
                {
                    strona_glowna main = new strona_glowna((long)czytelnik.First().id_czytelnik);
                    this.Close();
                    main.Show();
                    //TODO: Dialog "Zalogowano pomyślnie"
                    //main.ShowDialog();
                    login.Text = "";
                    password.Text = "";
                }
                else
                {
                    password.Text = "";
                    error_label.Show();
                }
            }
        }
    }
}
