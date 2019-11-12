using System;
using System.Collections.Generic;
using System.Text;

namespace BookShop
{
    public interface IBookService
    {
        void AddBook(string title, string author, string genre, double price);
        void OrderedListOfBooks(int orderBy);
        void SearchBook(int searchBy, string value);
        void DeleteBook(string title);
    }
}
