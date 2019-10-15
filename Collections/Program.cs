using System;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\modestas.alvinskis\Desktop\Tainings\Collections\Pop by Largest Final.csv";

            CsvReader reader = new CsvReader(filePath);
        }
    }
}
