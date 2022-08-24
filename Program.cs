using System;
using System.Collections.Generic;


Book fellowship = new Book("Fellowship of the Ring", "JRR Tolkien", "351", new DateTime(1954, 06, 27));
Book screwTape = new Book("The ScrewTape Letters", "C.S. Lewis", "200", new DateTime(1960, 06, 27));
Book cthulu = new Book("Cthulu", "H.P. LoveCraft", "500", new DateTime(1950, 03, 30));

List<Book> listOfBooks = new List<Book>();
listOfBooks.Add(fellowship);
listOfBooks.Add(screwTape);
listOfBooks.Add(cthulu);

foreach (Book book in listOfBooks)
{
    Console.WriteLine($"{book.Title} was written by {book.Author} in {book.PrintDate} with {book.NumberOfPages} pages.");
}

public class Book
{
    public Book(string title, string author, string numberOfPages, DateTime printed)
    {
        Title = title;
        Author = author;
        NumberOfPages = numberOfPages;
        PrintDate = printed;
    }
    public String Title { get; set; }
    public String Author { get; set; }
    public String NumberOfPages { get; set; }
    public DateTime PrintDate { get; set; }
}