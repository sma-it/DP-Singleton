using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening4
{
    internal class LibraryCatalogue
    {
        private List<Book> _books;

        // TODO: Implementeer de Singleton pattern hier
        private static LibraryCatalogue _instance;

        public static LibraryCatalogue Instance()
        {
            if (_instance == null) _instance = new LibraryCatalogue();
            return _instance;
        }

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
            return _books.Where(book => !book.IsCheckedOut).ToList();
        }

        public void CheckoutBook(string title)
        {
            // TODO: Implementeer een methode die een boek uitleent (zet IsCheckedOut op true voor het gekozen boek)
            var bookToCheckout = _books.FirstOrDefault(book => book.Title.Equals(title, StringComparison.OrdinalIgnoreCase) && !book.IsCheckedOut);
            if (bookToCheckout != null)
            {
                bookToCheckout.IsCheckedOut = true;
                Console.WriteLine($"Het boek '{title}' is succesvol uitgeleend.");
            }
            else
            {
                Console.WriteLine($"Het boek '{title}' is niet beschikbaar of bestaat niet in de catalogus.");
            }
        }
    }
}


