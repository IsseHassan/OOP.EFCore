using Microsoft.EntityFrameworkCore;
using OOP.EFCore.ConsoleApp.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.EFCore.ConsoleApp.DAL.BookMap
{
    public class BookMapp : IEntityTypeConfiguration<Book>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(b => b.BookId);

            builder.Property(b => b.Title)
                .IsRequired()
                .HasMaxLength(250);

            builder.Property(b => b.CreatedDate)
                .HasDefaultValueSql("GETDATE");

            builder.HasData(
                new Book() { BookId = 1, Title = "Devlet", CategoryId = 1},
                new Book() { BookId = 2, Title = "Yoldaki Isikler", CategoryId = 1 },
                new Book() { BookId = 3, Title = "Yanlizlik Sozleri" , CategoryId = 1 },
                new Book() { BookId = 4, Title ="Nageeye", CategoryId = 3 }

                );

            builder.HasOne(b => b.Category)
                .WithMany(c =>  c.Books)
                .HasForeignKey(b => b.CategoryId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
