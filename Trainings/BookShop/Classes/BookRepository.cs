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
            if (book.Exists(b => b.Title.ToUpper() == title.ToUpper()) == true)
            {
                Console.WriteLine("\nThe book already exists!!!");
            }
            else
            {
                if (book.Count <= 15)
                {
                    using (StreamWriter file = new StreamWriter(_path, true))
                    {
                        file.Write($"{Environment.NewLine}{title},{author},{genre},{price}");
                        Console.WriteLine($"\nYou have added book:\nTitle: {title}\nAuthor: {author}\nGenre: {genre}\nPrice: {price}");
                    }
                }
                else
                {
                    Console.WriteLine("\nToo many books in the bookshop, max 15 books!!!");
                }
            }
        }

        //List of ordered books
        public void OrderedListOfBooks(int orderBy)
        {
            var book = ProcessFile();

            switch (orderBy)
            {
                case 1:
                    Console.WriteLine("\nList of books ordered by title:");
                    book = book.OrderBy(b => b.Title).ToList();
                    break;
                case 2:
                    Console.WriteLine("\nList of books ordered by author:");
                    book = book.OrderBy(b => b.Author).ToList();
                    break;
                case 3:
                    Console.WriteLine("\nList of books ordered by genre:");
                    book = book.OrderBy(b => b.Genre).ToList();
                    break;
                case 4:
                    Console.WriteLine("\nList of books ordered by price:");
                    book = book.OrderBy(b => b.Price).ToList();
                    break;
            }

            WriteList(book);
        }

        //Search book
        public void SearchBook(int searchBy, string value)
        {
            var book = ProcessFile();
            switch (searchBy)
            {
                case 1:
                    book = book.FindAll(b => b.Title.Trim().ToUpper() == value.ToUpper());
                    if (book.Count == 0)
                    {
                        Console.WriteLine("\nNothing found here");
                    }
                    break;
                case 2:
                    book = book.FindAll(b => b.Author.Trim().ToUpper() == value.ToUpper());
                    if (book.Count == 0)
                    {
                        Console.WriteLine("\nNothing found here");
                    }
                    break;
                case 3:
                    book = book.FindAll(b => b.Genre.Trim().ToUpper() == value.ToUpper());
                    if (book.Count == 0)
                    {
                        Console.WriteLine("\nNothing found here");
                    }
                    break;
                case 4:
                    var price = 0.0;
                    var toString = double.TryParse(value, out price);
                    book = book.FindAll(b => b.Price == price);
                    if (book.Count == 0)
                    {
                        Console.WriteLine("\nNothing found here");
                    }
                    break;
            }

            WriteList(book);
        }

        //Delete a book by title
        public void DeleteBook(string title)
        {
            var book = ProcessFile();
            if (book.Exists(b => b.Title.ToUpper() == title.ToUpper()) == false)
            {
                Console.WriteLine("\nNothing to delete");
            }
            else
            {
                var bookToDelete = book.Single(b => b.Title.ToUpper() == title.ToUpper());
                Console.WriteLine("\nYou have deleted:\n" +
                    $"{bookToDelete.Title}, {bookToDelete.Author}, {bookToDelete.Genre}, {bookToDelete.Price}");
                book.Remove(bookToDelete);
                using (StreamWriter file = new StreamWriter(_path, false))
                {
                    file.Write("Title, Author, Genre, Price");
                    foreach (var rewriteBook in book)
                    {
                        file.Write($"{Environment.NewLine}{rewriteBook.Title},{rewriteBook.Author},{rewriteBook.Genre},{rewriteBook.Price}");
                    }
                }
            }
        }

        //Write Book list
        private static void WriteList(IEnumerable<Book> list)
        {
            Console.WriteLine();
            foreach (var item in list)
            {
                Console.WriteLine($"{item.Title}, {item.Author}, {item.Genre}, {item.Price}");
            }
        }
    }
}
