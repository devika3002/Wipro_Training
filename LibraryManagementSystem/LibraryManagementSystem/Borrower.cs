using System.Collections.Generic;

namespace LibraryManagementSystem
{
    public class Borrower
    {
        public string Name { get; set; }

        // library card number for the borrower
        public string LibraryCardNumber { get; set; }

        // List to store all books borrowed by  borrower
        public List<Book> BorrowedBooks { get; set; }

        // Constructor
        public Borrower(string name, string libraryCardNumber)
        {
            Name = name;
            LibraryCardNumber = libraryCardNumber;
            BorrowedBooks = new List<Book>();
        }

        // Method to borrow a book
        public void BorrowBook(Book book)
        {
            BorrowedBooks.Add(book);
        }

        // Method to return a book
        public void ReturnBook(Book book)
        { 
            BorrowedBooks.Remove(book);
        }
    }
}
