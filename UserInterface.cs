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
                           
                            break;
                        case 2:
                            _bookshelf.AddCustomBook();
                            
                            break;
                        case 3:
                            _bookshelf.RemoveBookByTitle();
                           
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
    }
}
