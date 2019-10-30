using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using CsvHelper;

namespace BookShop
{
    class BookRepository
    {
        private static string _path;
        public BookRepository(string path)
        {
            _path = path;
        }

        //var book = ProcessFile(_path);

        public List<Book> ProcessFile()
        {
            return File.ReadAllLines(_path)
                   .Skip(1)
                   .Where(line => line.Length > 1)
                   .Select(Book.ParseFromCsv)
                   .ToList();
        }
        //List<Book> book = new List<Book>();
        //public void BookReader()
        //{
        //    using (TextReader reader = File.OpenText(_filePath))
        //    {
        //        CsvReader csv = new CsvReader(reader);
        //        csv.Configuration.Delimiter = ", ";
        //        csv.Configuration.MissingFieldFound = null;
        //        while (csv.Read())
        //        {
        //            Book record = csv.GetRecord<Book>();
        //            book.Add(record);
        //        }
        //    }
        //}
        //public void AddBook(string title, string author, string genre, double price)
        //{
        //    try
        //    {
        //        using (StreamWriter file = new StreamWriter(_filePath, true))
        //        {
        //            file.WriteLine($"{title}, {author}, {genre}, {price}");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new ApplicationException("Something goes wrong: ", ex);
        //    }
        //}
        //public void OrderedList()
        //{
        //    Console.WriteLine("List of books ordered by genre and author:\n");
        //    var orderedBook = book.OrderBy(b => b.Genre).ThenBy(b => b.Author);
        //    foreach (var order in orderedBook)
        //    {
        //        Console.WriteLine($"Title: {order.Title}; Author: {order.Author}; Genre: {order.Genre}; Price: {order.Price}");
        //    }
        //}
        //public void SearchBook(string title)
        //{
        //    var searchBook = book.Find(b => b.Title == title);
        //    Console.WriteLine($"Found book by title '{title}':\n{searchBook.Title} by {searchBook.Author}");
        //}
        //public void DeleteBook(string title)
        //{
        //    //BookReader();
        //    var bookToDelete = book.Single(b => b.Title == title);
        //    book.Remove(bookToDelete);
        //    using (StreamWriter file = new StreamWriter(_filePath, false))
        //    {
        //        foreach (var rewriteBook in book)
        //        {
        //            file.WriteLine($"{rewriteBook.Title}, {rewriteBook.Author}, {rewriteBook.Genre}, {rewriteBook.Price}");
        //        }
        //    }
        //}
    }
}
