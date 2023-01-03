using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OOP.EFCore.ConsoleApp.Entities;
using System;

namespace OOP.EFCore.ConsoleApp.DAL.BookMap
{
    public class BookDetailMap : IEntityTypeConfiguration<BookDetail>
    {
        public void Configure(EntityTypeBuilder<BookDetail> builder)
        {
            builder.HasKey(bd => bd.BookDetailId);

            builder.Property(bd => bd.ISSN)
                .IsRequired()
                .HasDefaultValue("0000-0000-0000");

            builder.Property(bd => bd.Year)
                .HasDefaultValue(DateTime.Now.Year);


            //Iliski kurma one to-one
            builder.HasOne(bd => bd.Book)
                .WithOne(b => b.BookDetail)
                .HasForeignKey<BookDetail>(bd => bd.BookId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
