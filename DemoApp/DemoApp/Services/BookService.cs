using DemoApp.Models;
using System.Collections.Generic;

namespace DemoApp.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public IEnumerable<Book> GetBooks()
        {
            return _bookRepository.GetBooks();
        }

        private double GetSecretNumber()
        {
            return 50 * 8;
        }
    }
}