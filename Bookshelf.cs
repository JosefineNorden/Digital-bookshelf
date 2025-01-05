using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_bookshelf
{
    internal class Bookshelf
    {
        private List<Book> _books = new List<Book>();

        public void AddBook(Book book)
        {
            _books.Add(book);
        }

        public bool RemoveBookByTitle(string title)

        {
            Book bookToRemove = _books.Find(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (bookToRemove != null)
            {
                _books.Remove(bookToRemove);
                return true;
            }

            return false;
        }
        public void DisplayBooks()
        {
            if (_books.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("***   ***   ***");
                Console.WriteLine("");
                Console.ResetColor();
                Console.WriteLine("- Empty-");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("");
                Console.WriteLine("***   ***   ***");
                Console.ResetColor();
            }
            else
            {
                foreach (Book book in _books)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("*****     *****     *****     *****     *****");
                    Console.ResetColor();
                    book.DisplayInfo();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("     *****     *****     *****     *****     ");
                    Console.ResetColor();
                }
            }
        }
    }
}
