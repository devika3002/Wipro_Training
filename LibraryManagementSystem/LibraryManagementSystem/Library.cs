using System.Collections.Generic;
using System.Linq;

namespace LibraryManagementSystem
{
    public class Library
    {
        public List<Book> Books { get; set; }
        public List<Borrower> Borrowers { get; set; }
        //Constructor
        public Library()
        {
            Books = new List<Book>();
            Borrowers = new List<Borrower>();
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public void RegisterBorrower(Borrower borrower)
        {
            Borrowers.Add(borrower);
        }

        public void BorrowBook(string isbn, string libraryCardNumber)
        {
            //find book that is available
            Book? book = Books.FirstOrDefault(
                b => b.ISBN == isbn && !b.IsBorrowed);
            //find the borrower

            Borrower? borrower = Borrowers.FirstOrDefault(
                b => b.LibraryCardNumber == libraryCardNumber);

            if (book != null && borrower != null)
            {
                book.Borrow();
                borrower.BorrowBook(book);
            }
        }

        public void ReturnBook(string isbn, string libraryCardNumber)
        {
            Borrower? borrower = Borrowers.FirstOrDefault(
                b => b.LibraryCardNumber == libraryCardNumber);

            if (borrower != null)
            {
                Book? book = borrower.BorrowedBooks
                    .FirstOrDefault(b => b.ISBN == isbn);

                if (book != null)
                {
                    book.Return();
                    borrower.ReturnBook(book);
                }
            }
        }
    }
}