using System;

namespace SRP
{
    public class Book
    {

        public string Title { get ; }
        public string Author { get ; }
        public string Code { get ;  }
        //public string LibrarySector { get ; set; } //no es facilmente reutilizable
        //public string LibraryShelve { get ; set; } //el libro tiene responsabilidades adicionales que no le corresponden.

        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }

        //public void ShelveBook(String sector, String shelve)
        //{
            //this.LibrarySector = sector;
            //this.LibraryShelve = shelve;
        //}

    }
}
