using System;
using System.IO;

namespace BookShop
{
    class Program
    {
        static void Main(string[] args)
        {
            BookRepository book = new BookRepository(@"C:\Users\xmodi\Desktop\C#Trainings\Trainings\Trainings\BookShop\BookShop.csv");
            ////book.SearchBook(1, "Crime and Punishment");
            ////book.SearchBook(4, "15.99");
            ////book.DeleteBook("Moby Dick");
            //BookService bookService = new BookService(book);
            //bookService.AddBook("ne", "tavo", "reikalas", 45.98);
            //bookService.OrderedList(2);
            book.BuyBook("ne");


        }
    }
}
