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
    public partial class ksiazki_form : Form
    {
        public ksiazki_form()
        {
            InitializeComponent();
        }

        private void ksiazki_form_Load(object sender, EventArgs e)
        {
            DaneEntities main = new DaneEntities();

            var books = from book in main.Ksiazki
                        join wyp in main.Wypozyczenia
                        on book.id_ksiazka equals wyp.id_ksiazka
                        join kat in main.Kategorie
                        on book.id_kategoria equals kat.id_kategoria
                        join author in main.Autorzy
                        on book.id_autor equals author.id_autor
                        select new
                        {
                            book.isbn,
                            kategoria = kat.nazwa,
                            book.tytul,
                            book.opis,
                            autor = author.imie + " " + author.nazwisko,
                            wyp.data_wypozyczenia,
                            wyp.data_oddania,
                        };
            dataGridView1.DataSource = books.ToList();

            var number = from book in main.Ksiazki
                         group book by book.id_ksiazka into countGroup
                         select new
                         {
                             Count = countGroup.Count(),
                         };
            label1.Text = "Liczba książek w bibliotece: " + number.Count();
        }

    }
}
