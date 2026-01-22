using NUnit.Framework;
using LibraryManagementSystem;

namespace LibraryManagementSystem.Tests
{
    [TestFixture]
    public class UnitTest1
    {
        private Library library;

        // Runs before each test
        [SetUp]
        public void Setup()
        {
            library = new Library();
        }

        // Test for adding a book
        [Test]
        public void AddBook_Test()
        {
            Book book = new Book("C#", "Author", "ISBN01");

            library.AddBook(book);

            Assert.That(library.Books.Count, Is.EqualTo(1));
        }

        // Test for registering a borrower
        [Test]
        public void RegisterBorrower_Test()
        {
            Borrower borrower = new Borrower("Sravya", "CARD01");

            library.RegisterBorrower(borrower);

            Assert.That(library.Borrowers.Count, Is.EqualTo(1));
        }

        // Test for borrowing a book
        [Test]
        public void BorrowBook_Test()
        {
            Book book = new Book("C#", "Author", "ISBN01");
            Borrower borrower = new Borrower("Sravya", "CARD01");

            library.AddBook(book);
            library.RegisterBorrower(borrower);

            library.BorrowBook("ISBN01", "CARD01");

            Assert.That(book.IsBorrowed, Is.True);
            Assert.That(borrower.BorrowedBooks.Count, Is.EqualTo(1));
        }

        // Test for returning a book
        [Test]
        public void ReturnBook_Test()
        {
            Book book = new Book("C#", "Author", "ISBN01");
            Borrower borrower = new Borrower("Sravya", "CARD01");

            library.AddBook(book);
            library.RegisterBorrower(borrower);

            library.BorrowBook("ISBN01", "CARD01");
            library.ReturnBook("ISBN01", "CARD01");

            Assert.That(book.IsBorrowed, Is.False);
            Assert.That(borrower.BorrowedBooks.Count, Is.EqualTo(0));
        }
    }
}
