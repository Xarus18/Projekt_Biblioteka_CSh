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
    public partial class rejestracja : Form
    {
        Czytelnicy czytelnik = new Czytelnicy();
        public rejestracja()
        {
            InitializeComponent();
        }

        private void rej_zaloguj_Click(object sender, EventArgs e)
        {
            login_form login = new login_form();
            login.Show();
            this.Close();
        }

        private void register_Click(object sender, EventArgs e)
        {
            DaneEntities mainData = new DaneEntities();

            var user_login = from user in mainData.Czytelnicy
                             where user.login == rej_login.Text.Trim()
                             select new { user.login };

            var admin_login = from admin in mainData.Pracownicy
                              where admin.login == rej_login.Text.Trim()
                              select new { admin.login };

            if (user_login.Any() || admin_login.Any())
            {
                MessageBox.Show("Użytkownik o podanym loginie już istnieje.");
                rej_login.Text = "";
                rej_haslo.Text = "";
                rej_conf_haslo.Text = "";
                rej_login.Focus();
            }
            else
            {
                if (rej_email.Text.Count() < 8)
                {
                    MessageBox.Show("E-mail musi mieć co najmniej 8 znaków.");
                    rej_email.Text = "";
                    rej_email.Focus();
                    return;
                }
                int nr_telefonu;
                if (rej_phone.Text != "")
                {
                    if (rej_phone.Text.Count() != 9)
                    {
                        MessageBox.Show("Nr telefonu musi składać się z 9 znaków.");
                        rej_phone.Text = "";
                        rej_phone.Focus();
                        return;
                    }
                }
                if (rej_login.Text.Count() < 3)
                {
                    MessageBox.Show("Login musi mieć co najmniej 3 znaki.");
                    rej_login.Text = "";
                    rej_login.Focus();
                    return;
                }
                if (rej_haslo.Text.Count() < 3)
                {
                    MessageBox.Show("Hasło musi mieć co najmniej 3 znaki.");
                    rej_haslo.Text = "";
                    rej_haslo.Focus();
                    return;
                }
                if (int.TryParse(rej_phone.Text.Trim(), out nr_telefonu))
                {
                    if (rej_haslo.Text.Trim() == rej_conf_haslo.Text.Trim())
                    {
                        czytelnik.email = rej_email.Text.Trim();
                        czytelnik.telefon = rej_phone.ToString();
                        czytelnik.login = rej_login.Text.Trim();
                        czytelnik.haslo = rej_haslo.Text.Trim();
                        czytelnik.data_urodzenia = dateTimePicker1.Value;

                        using (DaneEntities dane = new DaneEntities())
                        {
                            try
                            {
                                dane.Czytelnicy.Add(czytelnik);
                               // Czytelnicy.Entry(czytelnik).State = EntityState.Added;
                                dane.SaveChanges();
                                MessageBox.Show("Konto zostało utworzone!");
                                this.Close();
                            }
                            catch
                            {
                                MessageBox.Show("Wprowadzone dane nie są poprawne lub niektóre wymagane pola nie zostały uzupełnione.");
                                return;
                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show("Podane hasło nie jest identyczne.");
                        rej_haslo.Text = "";
                        rej_conf_haslo.Text = "";
                        rej_haslo.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Powyższy numer telefonu został podany nieprawidłowo!");
                    rej_phone.Text = "";
                    rej_phone.Focus();
                }
            }
        }
    }
}
