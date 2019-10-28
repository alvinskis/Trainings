using DemoApp.Models;
using System.Collections.Generic;

namespace DemoApp.Services
{
    public class BookRepository : IBookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            throw new System.NotImplementedException();
        }
    }
}