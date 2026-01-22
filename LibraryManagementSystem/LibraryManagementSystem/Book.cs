namespace LibraryManagementSystem
{
    public class Book
    {
        // Properties
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public bool IsBorrowed { get; private set; }

        // Constructor
        public Book(string title, string author, string isbn)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            IsBorrowed = false; // book is available initially
        }

        // Method to borrow the book
        public void Borrow()
        {
            IsBorrowed = true;
        }

        // Method to return the book
        public void Return()
        {
            IsBorrowed = false;
        }
    }
}
