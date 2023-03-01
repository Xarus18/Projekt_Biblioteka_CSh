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
    public partial class Admin_Panel : Form
    {
        long id_pracownika;
        public Admin_Panel(long id_pracownika)
        {
            InitializeComponent();
            this.id_pracownika = id_pracownika;
        }

        private void wyloguj_Click(object sender, EventArgs e)
        {
            login_form main = new login_form();
            main.Show();
            this.Close();
        }

        private void pracownicy_Click(object sender, EventArgs e)
        {
            pracownicy_form main = new pracownicy_form();
            main.Show();
        }

        private void czytelnicy_Click(object sender, EventArgs e)
        {
            czytelnicy_form main = new czytelnicy_form();
            main.Show();
        }

        private void ksiazki_Click(object sender, EventArgs e)
        {
            ksiazki_form main = new ksiazki_form();
            main.Show();
        }

        private void zwroc_Click(object sender, EventArgs e)
        {
            zwroc_form main = new zwroc_form();
            main.Show();
        }

        private void Wypozycz_Click(object sender, EventArgs e)
        {
            wypozycz_form main = new wypozycz_form();
            main.Show();
        }
    }
}
