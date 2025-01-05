using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_bookshelf
{
    internal class UserInterface
    {
        private Bookshelf _bookshelf;

        public UserInterface(Bookshelf bookshelf)
        {
            _bookshelf = bookshelf;
        }

        public void DisplayMenu()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("===*** Digital Bookshelf ***===");
            Console.ResetColor();
            Console.WriteLine("1. - View all books in your bookshelf");
            Console.WriteLine("2. - Add a new book");
            Console.WriteLine("3. - Remove a book by title");
            Console.WriteLine("4. - Exit your digital bookshelf");
        }

        public void HandleUserChoice()
        {
            int choice;

            while (true)
            {
                try
                {
                    DisplayMenu();
                    choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            _bookshelf.DisplayBooks();

                            Console.WriteLine("Press enter to return to the menu...");
                            Console.ReadLine();
                            Thread.Sleep(1000);
                            Console.WriteLine("...Loading...");
                            Thread.Sleep(1000);
                            Console.Clear();

                            break;
                        case 2:
                            AddCustomBook();

                            break;
                        case 3:
                            RemoveBookByTitle();

                            break;
                        case 4:
                            Console.WriteLine("Now exiting your digital bookshelf!");
                            Thread.Sleep(1000);
                            Console.WriteLine("");
                            Console.WriteLine("...Exiting...");
                            Thread.Sleep(1000);
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("***");
                            Thread.Sleep(500);
                            Console.WriteLine("   ***");
                            Thread.Sleep(500);
                            Console.WriteLine("      ***");
                            Thread.Sleep(500);
                            Console.WriteLine("         ***");
                            Console.ResetColor();
                            return;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Something went wrong: {ex.Message}");
                }
            }
        }

        private void RemoveBookByTitle()
        {
            try
            {
                Console.WriteLine("Enter the title of the book you wish to remove:");

                string title = Console.ReadLine();

                bool isRemoved = _bookshelf.RemoveBookByTitle(title);

                if (isRemoved)
                {
                    Console.WriteLine($"The book {title} has been removed from the digital bookshelf.");
                }
                else
                {
                    Console.WriteLine($"The book: {title} was not found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Something went wrong: {ex.Message}");
            }

            Console.WriteLine("Press enter to return to the menu...");
            Console.ReadLine();
            Thread.Sleep(1000);
            Console.WriteLine("...Loading...");
            Thread.Sleep(1000);
            Console.Clear();
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

                _bookshelf.AddBook(new Book(title, author, genre, isbn));
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
    }
}
