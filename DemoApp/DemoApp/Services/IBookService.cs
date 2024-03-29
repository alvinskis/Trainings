﻿using DemoApp.Models;
using System.Collections.Generic;

namespace DemoApp.Services
{
    public interface IBookService
    {
        IEnumerable<Book> GetBooks();
    }
}