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

        public void AddCustomBook()
        {
            try
            {
                Console.WriteLine("Enter the title of your book:");
                string title = Console.ReadLine();
                Console.WriteLine("Enter the author of your book:");
                string author = Console.ReadLine();
                Console.WriteLine("Enter the genre of your book:");
                string genre = Console.ReadLine();
                Console.WriteLine("Enter the ISBN-number of your book:");
                int isbn = int.Parse(Console.ReadLine());

                AddBook(new Book(title, author, genre, isbn));
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Something went wrong while adding the book {ex.Message}");
            }

            Console.WriteLine("Your book has been added successfully!");
            Console.WriteLine("Press enter to return to the menu...");
            Console.ReadLine();
            Thread.Sleep(1000);
            Console.WriteLine("...Loading...");
            Thread.Sleep(1000);
            Console.Clear();

        }

        public void RemoveBookByTitle()

        {
            try
            {
                Console.WriteLine("Enter the name of the book you wish to remove:");
                string title = Console.ReadLine();

                Book bookToRemove = _books.Find(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
                if (bookToRemove != null)
                {
                    _books.Remove(bookToRemove);
                    Console.WriteLine($"{bookToRemove.Title} has been removed from the digital bookshelf.");
                }
                else
                {
                    Console.WriteLine($"The book {bookToRemove.Title} was not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Something went wrong while removing your book: {ex.Message}");
            }

            Console.WriteLine("Press enter to return to the menu...");
            Console.ReadLine();
            Thread.Sleep(1000);
            Console.WriteLine("...Loading...");
            Thread.Sleep(1000);
            Console.Clear();
        }
        public void DisplayBooks()
        {
            if (_books.Count == 0)
            {
                Console.WriteLine("You have no books in your digital bookshelf.");
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

            Console.WriteLine("Press enter to return to the menu...");
            Console.ReadLine();
            Thread.Sleep(1000);
            Console.WriteLine("...Loading...");
            Thread.Sleep(1000);
            Console.Clear();

        }
    }
}
