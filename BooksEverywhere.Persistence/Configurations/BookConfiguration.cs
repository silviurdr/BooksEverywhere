using BooksEverywhere.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Persistence.Configurations
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasOne(bc => bc.BookCollection)
                .WithOne(b => b.Book)
                .HasForeignKey<BookCollection>(bc => bc.BookId);

            builder.HasOne(bc => bc.Details)
                .WithOne(b => b.Book)
                .HasForeignKey<BookDetails>(bd => bd.BookId);

            builder.HasOne(bc => bc.BookCallNumber)
                .WithOne(b => b.Book)
                .HasForeignKey<BookCallNumber>(bcn => bcn.BookId);

            builder.HasOne(bc => bc.BookTag)
                .WithOne(b => b.Book)
                .HasForeignKey<BookTag>(bt => bt.BookId);

        }
    }
}
