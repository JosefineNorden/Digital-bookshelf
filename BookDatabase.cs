using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Digital_bookshelf
{
    internal class BookDatabase
    {
        private List<Book> _books = new List<Book>();

        public BookDatabase()
        {
            _books.Add(new Book("The Great Gatsby", "F.Scott Fitzgerald", "Fiction", 1234));
            _books.Add(new Book("The Shining", "Stephen King", "Horror", 2345));
            _books.Add(new Book("Harry Potter and the Sorcer's stone", "J.K.Rowling", "Fantasy", 3456));
            _books.Add(new Book("Moby-Dick", "Herman Melville", "Adventure", 4567));
            _books.Add(new Book("Frankenstein", "Mary Shelley", "Fiction", 5678));
            _books.Add(new Book("Where the wild things are", "Maurice Sendak", "Fantasy", 6789));

        }
        public List<Book> GetBooks()
        {
            return _books;
        }
    }
}
