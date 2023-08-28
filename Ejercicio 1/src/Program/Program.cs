using System;
using System.Security.AccessControl;
using System.Collections.Generic;

namespace SRP
{

    class Program
    {
        static void Main()
        {
            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034");
            Book book2 = new Book("Pro C#","Troelsen","001-035");
            Shelves shelve1 = new Shelves();
            shelve1.NumShelve = 1;
            Sector sector1 = new Sector(); 
            sector1.SectorName = "literatura";
            // arme estanteria, sector y libros.
            shelve1.AddBook(book1);
            shelve1.AddBook(book2);
            sector1.AddShelves(shelve1);
            Console.WriteLine(sector1.SectorName);
            Console.WriteLine(sector1.ShelvesList);
            
            Console.WriteLine("Nombre del sector: " + sector1.SectorName);

            Console.WriteLine("Estanterías en el sector:");
            foreach (Shelves shelve in sector1.ShelvesList)
            {
                Console.WriteLine("Estantería #" + shelve.NumShelve);

                List<string> bookTitles = new List<string>();
                foreach (Book book in shelve.BooksInShelve)
                {
                    bookTitles.Add(book.Title);
                }

                string booksAsString = string.Join(", ", bookTitles);
                Console.WriteLine("Libros: " + booksAsString);
            }

        }
    }
}

