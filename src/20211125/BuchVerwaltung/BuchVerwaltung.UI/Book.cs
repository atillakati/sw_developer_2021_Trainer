using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuchVerwaltung.UI
{
    public class Book : IBook
    {
        private string _title;
        private string _author;
        private string _publisher;
        private DateTime _yearOfPublishing;

        public Book() { }

        public Book(string title, string author, string publisher, DateTime yearOfPublishing)
        {
            _title = title;
            _author = author;
            _publisher = publisher;
            _yearOfPublishing = yearOfPublishing;
        }

        public DateTime YearOfPublishing
        {
            get { return _yearOfPublishing; }
            set { _yearOfPublishing = value; }
        }

        public string Publisher
        {
            get { return _publisher; }
            set { _publisher = value; }
        }

        public string Author
        {
            get { return _author; }
            set { _author = value; }
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }
    }
}
