using BuchVerwaltung.UI.StorageTypes;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BuchVerwaltung.UI
{
    public partial class MainForm : Form
    {
        private List<IBook> _myBooks;
        private IStorage _storage;

        public MainForm()
        {
            InitializeComponent();

            //_storage = new JsonStorage();
            _storage = new XmlStorage();


            _myBooks = new List<IBook>();
        }

        private void ClearFormContents(object sender, EventArgs e)
        {
            txt_Titel.Text = string.Empty;
            txt_Autor.Text = string.Empty;
            txt_Verlag.Text = string.Empty;

            txt_Titel.Focus();
        }

        private void btt_add_Click(object sender, EventArgs e)
        {
            var newBook = new Book(txt_Titel.Text, txt_Autor.Text, txt_Verlag.Text, dateTimePicker1.Value);

            _myBooks.Add(newBook);
            
            ClearFormContents(null, null);
            DisplayBookList(_myBooks);
        }

        private void DisplayBookList(IEnumerable<IBook> booksToDisplay)           
        {
            txt_bookListView.Text = string.Empty;

            foreach (var book in booksToDisplay)
            {
                txt_bookListView.Text += book.Title + Environment.NewLine;
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(_myBooks == null || _myBooks.Count == 0)
            {
                return;
            }

            var erg = _storage.Save(_myBooks, "MyBookList.dat");
            if (erg)
            {
                MessageBox.Show("Bücherliste wurde erfolgreich gespeichert.", 
                                "Speichern", 
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _myBooks.Clear();

            _myBooks.AddRange(_storage.Load("MyBookList.dat"));

            DisplayBookList(_myBooks);
        }
    }
}
