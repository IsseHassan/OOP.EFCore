using System.Collections.Generic;

namespace OOP.EFCore.ConsoleApp.Entities
{
    public class Category            //Principle nesne , Tamel nesne
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }

        //Collection Naviagtion Propoert
        public ICollection<Book> Books { get; set; }
    }
}
