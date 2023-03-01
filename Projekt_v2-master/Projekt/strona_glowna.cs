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
    public partial class strona_glowna : Form
    {
        long id_czytelnika;

        public strona_glowna(long id_czytelnika)
        {
            InitializeComponent();
            this.id_czytelnika = id_czytelnika;
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            login_form login = new login_form();
            login.Show();
            this.Close();
        }

        private void wypoz_btn_Click(object sender, EventArgs e)
        {
            wypozyczenia_user_form main = new wypozyczenia_user_form(id_czytelnika);
            main.Show();
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            title.Clear();
            author.Clear();
            category.SelectedIndex = -1;
        }

        private void strona_glowna_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'daneDataSet.Kategorie' . Możesz go przenieść lub usunąć.
            this.kategorieTableAdapter.Fill(this.daneDataSet.Kategorie);
            WyswietlZalogowanego();
            booksDataGrid();
            category.SelectedIndex = -1;

        }

        void booksDataGrid()
        {
            DaneEntities main = new DaneEntities();

            var books = from book in main.Ksiazki
                        join cate in main.Kategorie
                        on book.id_kategoria equals cate.id_kategoria
                        join author in main.Autorzy
                        on book.id_autor equals author.id_autor
                        join wydaw in main.Wydawnictwa
                        on book.id_wydawnictwo equals wydaw.id_wydawnictwo
                        select new
                        {
                            book.isbn,
                            kategoria = cate.nazwa,
                            book.tytul,
                            book.opis,
                            autor = author.imie + " " + author.nazwisko,
                            wydawnictwo = wydaw.nazwa,
                        };
            dataGridView1.DataSource = books.ToList();
        }


        public void WyswietlZalogowanego()
        {
            DaneEntities dane = new DaneEntities();
            var zalogowany = from zalog in dane.Czytelnicy
                             where zalog.id_czytelnik == id_czytelnika
                             select new { zalog.login };
            zalogowanylabel.Text = "Witaj: " + zalogowany.First().login;
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            using (DaneEntities main = new DaneEntities())
            {
                var filtr1 = title.Text;
                var filtr2 = category.Text;
                var filtr3 = author.Text;

                if (category.Text == "")
                {
                    if (filtr1 == "")
                    {
                        var listaKsiazek = from book in main.Ksiazki
                                           join cate in main.Kategorie
                                           on book.id_kategoria equals cate.id_kategoria
                                           join author in main.Autorzy
                                           on book.id_autor equals author.id_autor
                                           join wydaw in main.Wydawnictwa
                                           on book.id_wydawnictwo equals wydaw.id_wydawnictwo
                                           where author.imie.Contains(filtr3) || author.nazwisko.Contains(filtr3)
                                           select new
                                           {
                                               book.isbn,
                                               kategoria = cate.nazwa,
                                               book.tytul,
                                               book.opis,
                                               autor = author.imie + " " + author.nazwisko,
                                               wydawnictwo = wydaw.nazwa,
                                           };
                        dataGridView1.DataSource = listaKsiazek.ToList();
                    }
                    else if (filtr3 == "")
                    {
                        var listaKsiazek = from book in main.Ksiazki
                                           join cate in main.Kategorie
                                           on book.id_kategoria equals cate.id_kategoria
                                           join author in main.Autorzy
                                           on book.id_autor equals author.id_autor
                                           join wydaw in main.Wydawnictwa
                                           on book.id_wydawnictwo equals wydaw.id_wydawnictwo
                                           where book.tytul.Contains(filtr1)
                                           select new
                                           {
                                               book.isbn,
                                               kategoria = cate.nazwa,
                                               book.tytul,
                                               book.opis,
                                               autor = author.imie + " " + author.nazwisko,
                                               wydawnictwo = wydaw.nazwa,
                                           };
                        dataGridView1.DataSource = listaKsiazek.ToList();
                    }
                    else
                    {
                        var listaKsiazek = from book in main.Ksiazki
                                           join cate in main.Kategorie
                                           on book.id_kategoria equals cate.id_kategoria
                                           join author in main.Autorzy
                                           on book.id_autor equals author.id_autor
                                           join wydaw in main.Wydawnictwa
                                           on book.id_wydawnictwo equals wydaw.id_wydawnictwo
                                           where book.tytul.Contains(filtr1)
                                           where author.imie.Contains(filtr3) || author.nazwisko.Contains(filtr3)
                                           select new
                                           {
                                               book.isbn,
                                               kategoria = cate.nazwa,
                                               book.tytul,
                                               book.opis,
                                               autor = author.imie + " " + author.nazwisko,
                                               wydawnictwo = wydaw.nazwa,
                                           };
                        dataGridView1.DataSource = listaKsiazek.ToList();
                    }

                }
                else
                {
                    if (filtr1 == "")
                    {
                        var listaKsiazek = from book in main.Ksiazki
                                           join cate in main.Kategorie
                                           on book.id_kategoria equals cate.id_kategoria
                                           join author in main.Autorzy
                                           on book.id_autor equals author.id_autor
                                           join wydaw in main.Wydawnictwa
                                           on book.id_wydawnictwo equals wydaw.id_wydawnictwo
                                           where cate.nazwa.Contains(filtr2)
                                           where author.imie.Contains(filtr3) || author.nazwisko.Contains(filtr3)

                                           select new
                                           {
                                               book.isbn,
                                               kategoria = cate.nazwa,
                                               book.tytul,
                                               book.opis,
                                               autor = author.imie + " " + author.nazwisko,
                                               wydawnictwo = wydaw.nazwa,
                                           };

                        dataGridView1.DataSource = listaKsiazek.ToList();
                    }
                    else if (filtr3 == "")
                    {
                        var listaKsiazek = from book in main.Ksiazki
                                           join cate in main.Kategorie
                                           on book.id_kategoria equals cate.id_kategoria
                                           join author in main.Autorzy
                                           on book.id_autor equals author.id_autor
                                           join wydaw in main.Wydawnictwa
                                           on book.id_wydawnictwo equals wydaw.id_wydawnictwo
                                           where book.tytul.Contains(filtr1)
                                           where author.imie.Contains(filtr3) || author.nazwisko.Contains(filtr3)

                                           select new
                                           {
                                               book.isbn,
                                               kategoria = cate.nazwa,
                                               book.tytul,
                                               book.opis,
                                               autor = author.imie + " " + author.nazwisko,
                                               wydawnictwo = wydaw.nazwa,
                                           };

                        dataGridView1.DataSource = listaKsiazek.ToList();
                    }
                    else
                    {
                        var listaKsiazek = from book in main.Ksiazki
                                           join cate in main.Kategorie
                                           on book.id_kategoria equals cate.id_kategoria
                                           join author in main.Autorzy
                                           on book.id_autor equals author.id_autor
                                           join wydaw in main.Wydawnictwa
                                           on book.id_wydawnictwo equals wydaw.id_wydawnictwo
                                           where book.tytul.Contains(filtr1)
                                           where cate.nazwa.Contains(filtr2)
                                           where author.imie.Contains(filtr3) || author.nazwisko.Contains(filtr3)

                                           select new
                                           {
                                               book.isbn,
                                               kategoria = cate.nazwa,
                                               book.tytul,
                                               book.opis,
                                               autor = author.imie + " " + author.nazwisko,
                                               wydawnictwo = wydaw.nazwa,
                                           };

                        dataGridView1.DataSource = listaKsiazek.ToList();
                    }

                }

            }
        }
    }
}
