using System;
using System.Collections.Generic;
using System.Text;

namespace BookShop
{
    public class BookService : IBookService
    {
        private IBookRepository _bookRepository;
        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public void AddBook(string title, string author, string genre, double price)
        {
            _bookRepository.AddBook(title, author, genre, price);
        }

        public void DeleteBook(string title)
        {
            _bookRepository.DeleteBook(title);
        }

        public void OrderedListOfBooks(int orderBy)
        {
            _bookRepository.OrderedListOfBooks(orderBy);
        }

        public void SearchBook(int searchBy, string value)
        {
            _bookRepository.SearchBook(searchBy, value);
        }
    }
}
