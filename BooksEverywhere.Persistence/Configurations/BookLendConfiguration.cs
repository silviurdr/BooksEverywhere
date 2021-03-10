using BooksEverywhere.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Persistence.Configurations
{
    class BookLendConfiguration : IEntityTypeConfiguration<BookLend>
    {
        public void Configure(EntityTypeBuilder<BookLend> builder)
        {
            builder.HasOne(bl => bl.Fine)
                .WithOne(f => f.BookLend)
                .HasForeignKey<Fine>(f => f.BookLendId)
                .IsRequired(false);

            builder.HasMany(bl => bl.Notifications)
                .WithOne(n => n.BookLend)
                .HasForeignKey(n => n.BookLendId);
        }
    }
}
