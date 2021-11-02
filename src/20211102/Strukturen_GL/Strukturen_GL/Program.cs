using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strukturen_GL
{
    struct Book
    {
        public string Title;
        public string Author;
        public string Isbn;
        public decimal Price;
        public int PublishYear;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Deklaration
            Book myBook;

            //Erzeugung
            myBook = new Book();

            Book myOtherBook = new Book();

            myOtherBook.Title = "TestTitel";
            myOtherBook.PublishYear = 1980;

            DisplayBook(myOtherBook);
            DisplayBook(myBook);
            myBook = ReadBookData();

            Console.WriteLine(myBook);

            ConsoleKeyInfo keyInfo = Console.ReadKey();            
        }

        static void DisplayBook(Book bookToDisplay)
        {
            Console.WriteLine(bookToDisplay.Title);
            Console.WriteLine(bookToDisplay.Author);           
            Console.WriteLine(bookToDisplay.PublishYear);            
        }

        static Book ReadBookData()
        {
            Book aNewBook = new Book();
            //eingaben bla bla..

            return aNewBook;
        }
    }
}
