using System;
using System.IO;

namespace BookShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new BookRepository(@"C:\Users\modestas.alvinskis\Desktop\Trainings\BookShop\BookShop.csv");
            book.OrderedList();

        }
    }
}
