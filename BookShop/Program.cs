using System;
using System.IO;

namespace BookShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new BookRepository(@"C:\Users\xmodi\Desktop\C#Trainings\Trainings\BookShop\BookShop.csv");
            book.ProcessFile();
        }
    }
}
