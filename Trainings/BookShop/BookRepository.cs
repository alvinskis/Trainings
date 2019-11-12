using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using CsvHelper;

namespace BookShop
{
    public class BookRepository : IBookRepository
    {
        private string _path;
        public BookRepository(string path)
        {
            _path = path;
        }

        //Read CSV file
        public List<Book> ProcessFile()
        {
            return File.ReadAllLines(_path)
                   .Skip(1)
                   .Where(line => line.Length > 1)
                   .Select(Book.ParseFromCsv)
                   .ToList();
        }
        
        //Add book to CSV file
        public void AddBook(string title, string author, string genre, double price)
        {
            var book = ProcessFile();
            if (book.Count < 15)
            {
                using (StreamWriter file = new StreamWriter(_path, true))
                {
                    file.WriteLine($"{title},{author},{genre},{price}");
                }
            }
            else
            {
                Console.WriteLine("Too many books in the bookshop, max 15 books");
            }
        }

        //List of ordered books
        public void OrderedListOfBooks(int orderBy)
        {
            var book = ProcessFile();

            switch (orderBy)
            {
                case 1:
                    Console.WriteLine("List of books ordered by title:\n");
                    book = book.OrderBy(b => b.Title).ToList();
                    break;
                case 2:
                    Console.WriteLine("List of books ordered by author:\n");
                    book = book.OrderBy(b => b.Author).ToList();
                    break;
                case 3:
                    Console.WriteLine("List of books ordered by genre:\n");
                    book = book.OrderBy(b => b.Genre).ToList();
                    break;
                case 4:
                    Console.WriteLine("List of books ordered by price:\n");
                    book = book.OrderBy(b => b.Price).ToList();
                    break;
            }

            foreach (var order in book)
            {
                Console.WriteLine($"Title: {order.Title}; Author: {order.Author}; Genre: {order.Genre}; Price: {order.Price}");
            }
        }

        //Search book
        public void SearchBook(int searchBy, string value)
        {
            var book = ProcessFile();
            switch (searchBy)
            {
                case 1:
                    book = book.FindAll(b => b.Title == value);
                    break;
                case 2:
                    book = book.FindAll(b => b.Author == value);
                    break;
                case 3:
                    book = book.FindAll(b => b.Genre == value);
                    break;
                case 4:
                    var toString = double.Parse(value);
                    book = book.FindAll(b => b.Price == toString);
                    break;
            }
            foreach (var searchedBook in book)
            {
                Console.WriteLine($"Searched book: {searchedBook.Title}, {searchedBook.Author}, {searchedBook.Genre}, {searchedBook.Price}");
            }
        }

        //Delete a book by title
        public void DeleteBook(string title)
        {
            var book = ProcessFile();
            var bookToDelete = book.Single(b => b.Title == title);
            book.Remove(bookToDelete);
            using (StreamWriter file = new StreamWriter(_path, false))
            {
                file.WriteLine("Title, Author, Genre, Price");
                foreach (var rewriteBook in book)
                {
                    file.WriteLine($"{rewriteBook.Title},{rewriteBook.Author},{rewriteBook.Genre},{rewriteBook.Price}");
                }
            }
        }

        public void BuyBook(string title)
        {
            var book = ProcessFile();
            List<Book> purchasedBook;
            purchasedBook = book.Where(b => b.Title == title).ToList();
            WriteList(purchasedBook);
        }
        private static void WriteList(IEnumerable<Book> list)
        {
            Console.WriteLine();
            foreach (var item in list)
            {
                Console.WriteLine("item: {0}", item.Title);
            }
        }
    }
}
