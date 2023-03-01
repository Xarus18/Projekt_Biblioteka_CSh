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
    public partial class czytelnicy_form : Form
    {
        public czytelnicy_form()
        {
            InitializeComponent();
        }

        void showDataGrid()
        {
            DaneEntities main = new DaneEntities();

            var reader = from wypozycz in main.Wypozyczenia
                         join czytelnik in main.Czytelnicy
                         on wypozycz.id_czytelnik equals czytelnik.id_czytelnik
                         join book in main.Ksiazki
                         on wypozycz.id_ksiazka equals book.id_ksiazka
                         join author in main.Autorzy
                         on book.id_autor equals author.id_autor
                         select new
                         {
                             czytelnik.login,
                             book.tytul,
                             autor = author.imie + " " + author.nazwisko,
                             book.opis,
                             wypozycz.data_wypozyczenia,
                             wypozycz.data_oddania,
                         };
            dataGridView1.DataSource = reader.ToList();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {

            DaneEntities main = new DaneEntities();

            var filtr1 = login.Text;

            var reader = from wypozycz in main.Wypozyczenia
                         join czytelnik in main.Czytelnicy
                         on wypozycz.id_czytelnik equals czytelnik.id_czytelnik
                         join book in main.Ksiazki
                         on wypozycz.id_ksiazka equals book.id_ksiazka
                         join author in main.Autorzy
                         on book.id_autor equals author.id_autor
                         where czytelnik.login == filtr1
                         select new
                         {
                             czytelnik.login,
                             book.tytul,
                             autor = author.imie + " " + author.nazwisko,
                             book.opis,
                             wypozycz.data_wypozyczenia,
                             wypozycz.data_oddania,
                         };
            dataGridView1.DataSource = reader.ToList();

        }

        private void czytelnicy_form_Load(object sender, EventArgs e)
        {
            showDataGrid();
        }
    }
}
