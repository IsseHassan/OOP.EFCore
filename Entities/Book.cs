using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.EFCore.ConsoleApp.Entities
{
    public class Book            //Dependent Entity
    {
       
        public int BookId { get; set; }
        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }
        public decimal Price { get; set; }

        //Foreign Key
        public int? CategoryId { get; set; }

        //Simple Navigation Propert
        public Category Category { get; set; }

        //Navigtion
        public BookDetail BookDetail { get; set; }
    }
}
