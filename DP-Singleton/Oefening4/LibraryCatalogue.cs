using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening4
{
    internal class LibraryCatalogue
    {
        // TODO: Implementeer de Singleton pattern hier
        private List<Book> _books;

        private LibraryCatalogue()
        {
            _books = new List<Book>
            {
                new Book("Harry Potter en de Steen der Wijzen", "J.K. Rowling"),
                new Book("De Hobbit", "J.R.R. Tolkien"),
                new Book("Het Achterhuis", "Anne Frank")
            };
        }

        public List<Book> GetAvailableBooks()
        {
            // TODO: Implementeer een methode die een lijst van beschikbare boeken (niet uitgeleend) retourneert
        }

        public void CheckoutBook(string title)
        {
            // TODO: Implementeer een methode die een boek uitleent (zet IsCheckedOut op true voor het gekozen boek)
        }
    }
}


