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
        string _filePath = @"C:\Users\modestas.alvinskis\Desktop\Trainings\BookShop\BookShop.csv";
        List<Book> book = new List<Book>();
        public void BookReader()
        {
            using (TextReader reader = File.OpenText(_filePath))
            {
                CsvReader csv = new CsvReader(reader);
                csv.Configuration.Delimiter = ", ";
                csv.Configuration.MissingFieldFound = null;
                while (csv.Read())
                {
                    Book record = csv.GetRecord<Book>();
                    book.Add(record);
                }
            }
        }
        public void AddBook(string title, string author, string genre, double price)
        {
            try
            {
                using (StreamWriter file = new StreamWriter(_filePath, true))
                {
                    file.WriteLine($"{title}, {author}, {genre}, {price}");
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Something goes wrong: ", ex);
            }
        }
        public void OrderedList()
        {
            var orderedBook = book.OrderBy(b => b.Genre).ThenBy(b => b.Author);
            foreach (var order in orderedBook)
            {
                Console.WriteLine($"Title: {order.Title}; \t\tAuthor: {order.Author}\t; Genre: {order.Genre}; Price: {order.Price}");
            }
        }
        public void SearchBook(string title)
        {
            var searchBook = book.Find(b => b.Title == title);
            Console.WriteLine(searchBook.Author);
        }
        public void DeleteBook(string title)
        {
        }
    }
}
