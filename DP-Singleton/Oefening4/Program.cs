using Oefening4;

// TODO: werk de classes LibraryCatalogue en LibraryUser uit.

LibraryCatalogue catalogue = LibraryCatalogue.Instance();

LibraryUser user1 = new LibraryUser();
LibraryUser user2 = new LibraryUser();

// Simuleer een scenario waarin twee gebruikers boeken bekijken en lenen
user1.ViewAvailableBooks();
user1.BorrowBook("De Hobbit");
user2.ViewAvailableBooks();
user2.BorrowBook("Harry Potter en de Steen der Wijzen");
user1.ViewAvailableBooks();
