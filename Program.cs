namespace Digital_bookshelf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookDatabase bookDatabase = new BookDatabase();
            Bookshelf bookshelf = new Bookshelf();

            foreach (var book in bookDatabase.GetBooks())
            {
                bookshelf.AddBook(book);
            }

            UserInterface userinterface = new UserInterface(bookshelf);

            userinterface.HandleUserChoice();
        }
    }
}
