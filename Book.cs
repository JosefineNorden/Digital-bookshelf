using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_bookshelf
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public int ISBN { get; set; }

        public Book(string title, string author, string genre, int isbn)
        {
            Title = title;
            Author = author;
            Genre = genre;
            ISBN = isbn;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"{Title} by {Author} ({ISBN}), {Genre}");
        }

    }
}
