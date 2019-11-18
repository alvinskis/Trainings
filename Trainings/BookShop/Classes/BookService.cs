using System;
using System.Collections.Generic;
using System.Linq;
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

        //Buy book
        public List<Book> BuyBook(List<string> title)
        {
            List<Book> book = _bookRepository.ProcessFile();
            List<Book> purchased = new List<Book>();
            for (int i = 0; i < title.Count; i++)
            {
                string item = title[i];
                purchased.AddRange(book.Where(b => b.Title.ToUpper() == item.ToUpper()).ToList());
            }
            BooksCart.BookCart = purchased;
            return purchased;
        }
        public void Discount()
        {
            var book = BooksCart.BookCart;
            var genreCount = book.Select(b => b.Genre).Distinct().Count();
            var price = book.Sum(b => b.Price);
            double totalPrice = 0.0;
            double discount = 0.0;
            var numOfBooks = book.Count;
            switch (numOfBooks)
            {
                case 2:
                    totalPrice = price * 0.9;
                    break;
                case 3:
                    totalPrice = price * 0.85;
                    break;
                case 4:
                    totalPrice = price * 0.8;
                    break;
                case 5://Vietoj if susikurti atskira private methoda ir is cia callinti
                    if (genreCount >= 3)
                    {
                        totalPrice = price * 0.5;
                    }
                    else
                    {
                        totalPrice = price * 0.75;
                    }
                    break;
            }
            discount = price - totalPrice;
            double finalDiscount = Math.Round(discount, 2);
            double finalPrice = Math.Round(totalPrice, 2);
            Console.WriteLine($"\nPrice: {price}\n" +
                $"Discount: {finalDiscount}\n" +
                $"FinalPrice: {finalPrice}");
        }
        public void CurrentCart()
        {
            foreach (var item in BooksCart.BookCart)
            {
                Console.WriteLine($"Title: {item.Title}; Price: {item.Price}");
            }
        }
    }
}
