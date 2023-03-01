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
    public partial class pracownicy_form : Form
    {
        public pracownicy_form()
        {
            InitializeComponent();
        }

        private void pracownicy_form_Load(object sender, EventArgs e)
        {
            DaneEntities main = new DaneEntities();

            var books = from pracownik in main.Pracownicy
                        join rola in main.Role
                        on pracownik.id_rola equals rola.id_rola
                        select new
                        {
                            pracownik.id_pracownik,
                            pracownik.login,
                            pracownik.haslo,
                            rola = rola.nazwa,
                        };
                        
            dataGridView1.DataSource = books.ToList();
        }
    }
}
