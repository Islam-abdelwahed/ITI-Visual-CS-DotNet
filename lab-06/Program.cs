namespace lab_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book> {

            new Book("111", "How to escape from ITI",
                new string[] { "Islam Elsayed" },
                new DateTime(2008, 8, 1),
                500),

            new Book("222", "How to escape from Egypt",
                new string[] { "No Body Can" },
                new DateTime(1994, 10, 21),
                750)};

            LibraryEngine.ProcessBooks(books, BookFunctions.GetTitle);

            LibraryEngine.ProcessBooks(books, BookFunctions.GetPrice);

            LibraryEngine.ProcessBooks(books, delegate (Book B) { return B.ISBN; });

            LibraryEngine.ProcessBooks(books, B => B.PublicationDate.ToShortDateString());
        }
    }

}
