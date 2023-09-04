using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening4
{
    internal class LibraryUser
    {
        public void ViewAvailableBooks()
        {
            // TODO: Haal de lijst met beschikbare boeken op en print deze
            foreach(var book in LibraryCatalogue.Instance().GetAvailableBooks())
            {
                Console.WriteLine($"{book.Title} by {book.Author}");
            }
        }

        public void BorrowBook(string title)
        {
            // TODO: Leen een boek uit via de LibraryCatalogue singleton
            LibraryCatalogue.Instance().CheckoutBook(title);
        }
    }
}
