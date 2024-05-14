// See https://aka.ms/new-console-template for more information
using CodingWiki_DataAccess.Data;
using CodingWiki_Models.Models;
using CodingWikiDataAccess.Migrations;

Console.WriteLine("Hello, World!");

//getALlBooks();
//AddBooksToDb();
//void getALlBooks()
//{
//    using var context = new ApplicationDbContext();
//    var books = context.Books.ToList();
//    foreach ( var book in books)
//    {
//        Console.WriteLine(book.Title+"--"+book.Price);
//    }
//}

//void AddBooksToDb()
//{
//    using var context = new ApplicationDbContext();
//    var book = new Book() { Title = "Hello", ISBN = "12", Price = 12.99m, Publisher_Id = 2 };
//    var books = context.Books.Add(book);
//    context.SaveChanges();
//    Console.WriteLine(book+" has been addded successfully");
//}