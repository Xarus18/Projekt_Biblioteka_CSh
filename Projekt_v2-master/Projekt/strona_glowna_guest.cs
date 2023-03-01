using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;


namespace Projekt
{
    public partial class strona_glowna_guest : Form
    {
        public strona_glowna_guest()
        {
            InitializeComponent();
        }



        private void strona_glowna_guest_Load(object sender, EventArgs e)
        {

            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'daneDataSet.Kategorie' . Możesz go przenieść lub usunąć.
            this.kategorieTableAdapter.Fill(this.daneDataSet.Kategorie);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'daneDataSet.Kategorie' . Możesz go przenieść lub usunąć.
            this.kategorieTableAdapter.Fill(this.daneDataSet.Kategorie);
            booksDataGrid();
            category.SelectedIndex = -1;
            WyswietlNiezalogowanego();

        }
        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            title.Clear();
            author.Clear();
            category.SelectedIndex = -1;
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            login_form main = new login_form();
            main.Show();
            this.Close();
            
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
                    if(filtr1 == "")
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
                    else if(filtr3 == "")
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
                    if(filtr1 == "")
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
                    else if(filtr3 == "")
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
       
        public void WyswietlNiezalogowanego()
        {
            zalogowanylabel.Text = "Witaj: Niezalogowany";
        }
    }
}
