using System;
using System.Collections.Generic;
using System.IO;

namespace BookShop
{
    class Program
    {
        static void Main(string[] args)
        {
            BookRepository book = new BookRepository(@"C:\Users\xmodi\Desktop\C#Trainings\Trainings\Trainings\BookShop\BookShop.csv");
            BookService bookService = new BookService(book);
            Console.Write("Press:\n" +
                "s to start\n" +
                "q to quit \n" +
                "> ");
            string input = Console.ReadLine();
            while (input != "s" && input != "q" && input != "h")
            {
                Console.Write("\nPlease enter valid option\n" +
                    "> ");
                input = Console.ReadLine();
            }
            if (input == "s")
            {
                while (input != "q")
                {
                    Console.Write("\nPlease enter the following option:\n" +
                    "1 to Add the Book\n" +
                    "2 to Get the List of Books\n" +
                    "3 to Search for a Book\n" +
                    "4 to Delete the Book\n" +
                    "5 to Buy a Book\n" +
                    "6 to Get the Current Cart\n" +
                    "q to quit\n" +
                    "> ");

                    input = Console.ReadLine();
                    while (input != "1" && input != "2" && input != "3" && input != "4" && input != "5" && input != "6" && input != "q")
                    {
                        Console.Write("\nPlease enter valid option\n" +
                            "> ");
                        input = Console.ReadLine();
                    }
                    if (input == "1")//AddBook
                    {
                        string title;
                        string author;
                        string genre;
                        double price;

                        Console.WriteLine("To add a book enter following information: ");
                        Console.Write("Title: ");
                        title = Console.ReadLine();
                        Console.Write("Author: ");
                        author = Console.ReadLine();
                        Console.Write("Genre: ");
                        genre = Console.ReadLine();
                        Console.Write("Price: ");
                        while (double.TryParse(Console.ReadLine(), out price) == false)
                        {
                            Console.Write("\nIncorrect price format\n" +
                                "Please enter again: ");
                        }

                        bookService.AddBook(title, author, genre, price);
                    }
                    else if (input == "2")//OrderedListOfBooks
                    {
                        Console.Write("\nTo get list of the books enter:\n" +
                            "1 -> Ordered by Title\n" +
                            "2 -> Ordered by Author\n" +
                            "3 -> Ordered by Genre\n" +
                            "4 -> Ordered by Price\n" +
                            "> ");
                        int orderByNo = int.Parse(Console.ReadLine());
                        bookService.OrderedListOfBooks(orderByNo);
                    }
                    else if (input == "3")//SearchBook
                    {
                        Console.Write("\nTo search the book enter:\n" +
                            "1 -> Search by Title\n" +
                            "2 -> Search by Author\n" +
                            "3 -> Search by Genre\n" +
                            "4 -> Search by Price\n" +
                            "> ");
                        int searchByNo = int.Parse(Console.ReadLine());
                        switch (searchByNo)
                        {
                            case 1:
                                Console.Write("\nEnter title of the book: ");
                                break;
                            case 2:
                                Console.Write("\nEnter author of the book: ");
                                break;
                            case 3:
                                Console.Write("\nEnter genre of the book: ");
                                break;
                            case 4:
                                Console.Write("\nEnter price of the book: ");
                                break;
                        }
                        string searchInput = Console.ReadLine();
                        Console.WriteLine("\nList of found books:");
                        bookService.SearchBook(searchByNo, searchInput);
                    }
                    else if (input == "4")//DeleteBook
                    {
                        Console.Write("\nEnter title of the book which you want to delete:\n" +
                            "> ");
                        string deleteBook = Console.ReadLine();
                        bookService.DeleteBook(deleteBook);

                    }
                    else if (input == "5")//BuyBook
                    {
                        Console.Write("\nEnter a title of the books you want to buy:\n" +
                            "Press q when done.\n" +
                            "> ");
                        List<string> booksToBuyList = new List<string>();
                        string buyBook = Console.ReadLine();
                        while (buyBook != "q")
                        {
                            booksToBuyList.Add(buyBook);
                            Console.Write("> ");
                            buyBook = Console.ReadLine();
                        }
                        bookService.BuyBook(booksToBuyList);
                    }
                    else if (input == "6")//CurrentCart
                    {
                        if (BooksCart.BookCart == null)
                        {
                            Console.WriteLine("\nNothing in the cart yet");
                        }
                        else
                        {
                            Console.WriteLine("\nCurrent Cart: ");
                            bookService.CurrentCart();
                            bookService.Discount();
                        }
                    }
                    else if (input == "q")
                    {
                        Console.WriteLine("\nExiting Program");
                        Environment.Exit(0);
                    }
                }
            }
            else if (input == "q")
            {
                Console.WriteLine("\nExiting Program");
                Environment.Exit(0);
            }
            
        }
    }
}
