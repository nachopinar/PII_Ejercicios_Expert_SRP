using System;
using System.Collections.Generic;


namespace SRP 
{
    public class Sector
    {
        public List<Shelves> ShelvesList {get; set;} = new List<Shelves>();
        public  string SectorName {get; set;}

        public void AddShelves(Shelves newShelf) 
        {
            this.ShelvesList.Add(newShelf);
        }

    }

}


