using System;

namespace BuchVerwaltung.UI
{
    public interface IBook
    {
        string Author { get; set; }
        string Publisher { get; set; }
        string Title { get; set; }
        DateTime YearOfPublishing { get; set; }
    }
}