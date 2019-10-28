using DemoApp.Models;
using System.Collections.Generic;

namespace DemoApp.Services
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetBooks();
    }
}