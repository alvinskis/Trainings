using System;
using System.IO;

namespace BookShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new BookRepository();
            book.BookReader();
            book.OrderedList();
        }
    }
}
