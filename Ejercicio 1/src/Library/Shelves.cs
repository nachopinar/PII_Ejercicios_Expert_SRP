using System;
using System.Collections.Generic;


namespace SRP 
{
    public class Shelves 
    {
        public List<Book> BooksInShelve {get; set;} = new List<Book>();
        public  int NumShelve {get; set;}
    

    public void AddBook(Book newBook)
    {
        this.BooksInShelve.Add(newBook);
    }

    }
}