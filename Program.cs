using OOP.EFCore.ConsoleApp.DAL;
using System;
using System.Linq;
using System.Threading.Channels;

namespace OOP.EFCore.ConsoleApp
{
   public class Program
    {
        static void Main(string[] args)
        {

            //Cascade ile sildik
            var _context = new BookAppDbContext();
            var category = _context.Categories
                .Where(c => c.CategoryId == 1)
                .SingleOrDefault();

            _context.Categories.Remove(category);
            _context.SaveChanges();

            Console.WriteLine(8858888);
            Console.ReadKey();          
        }
    }
}
