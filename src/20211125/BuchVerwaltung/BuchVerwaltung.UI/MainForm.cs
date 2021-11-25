using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuchVerwaltung.UI
{
    public partial class MainForm : Form
    {
        private List<IBook> _myBooks;


        public MainForm()
        {
            InitializeComponent();

            _myBooks = new List<IBook>();
        }

        private void ClearFormContents(object sender, EventArgs e)
        {
            txt_Titel.Text = string.Empty;
            txt_Autor.Text = string.Empty;
            txt_Verlag.Text = string.Empty;
        }

        private void btt_add_Click(object sender, EventArgs e)
        {
            var newBook = new Book(txt_Titel.Text, txt_Autor.Text, txt_Verlag.Text, dateTimePicker1.Value);

            _myBooks.Add(newBook);

            ClearFormContents(null, null);
        }
    }
}
