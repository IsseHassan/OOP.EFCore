namespace OOP.EFCore.ConsoleApp.Entities
{
    public class BookDetail
    {
        public int BookDetailId { get; set; }

        //Foreingn Key -Unique
        public int BookId { get; set; }

        //Navigation propert
        public Book Book { get; set; }
        public string ISSN { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Year { get; set; }
    }
}
