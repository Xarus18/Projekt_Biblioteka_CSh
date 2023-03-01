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
    public partial class wypozyczenia_user_form : Form
    {
        long id_czytelnika;

        public wypozyczenia_user_form(long id_czytelnika)
        {
            InitializeComponent();
            this.id_czytelnika = id_czytelnika;
        }

        private void wypozyczenia_user_form_Load(object sender, EventArgs e)
        {

            showDataGrid();
            changeLabel();
            
        }

        void showDataGrid()
        {
            DaneEntities main = new DaneEntities();

            var filtr1 = id_czytelnika.ToString();

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

        void changeLabel()
        {
            DaneEntities main = new DaneEntities();

            var filtr1 = id_czytelnika;

            var number = from wypozyczenie in main.Wypozyczenia
                         join czytelnik in main.Czytelnicy
                         on wypozyczenie.id_czytelnik equals czytelnik.id_czytelnik
                         where czytelnik.id_czytelnik == filtr1
                         group wypozyczenie by wypozyczenie.id_wypozyczenie into countGroup
                         select new
                         {
                             Count = countGroup.Count(),
                         };
            label1.Text = "Liczba Wypożyczonych książek: " + number.Count();
        }
    }
}
