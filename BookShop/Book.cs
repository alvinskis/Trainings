using System;
using System.Collections.Generic;
using System.Text;

namespace BookShop
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public double Price { get; set; }

        internal static Book ParseFromCsv(string line)
        {
            var columns = line.Split(',');
            return new Book
            {
                Title = columns[0],
                Author = columns[1],
                Genre = columns[2],
                Price = double.Parse(columns[3])
            };
        }
    }
}
