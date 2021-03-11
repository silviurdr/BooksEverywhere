using BooksEverywhere.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Persistence.Configurations
{
    public class LibraryUserConfiguration : IEntityTypeConfiguration<LibraryUser>
    {
        public void Configure(EntityTypeBuilder<LibraryUser> builder)
        {
            builder.HasOne(lu => lu.Account)
                .WithOne(a => a.LibraryUser)
                .HasForeignKey<Account>(a => a.LibraryUserId);

            builder.HasOne(lu => lu.LibraryCard)
                .WithOne(lc => lc.LibraryUser)
                .HasForeignKey<LibraryCard>(lc => lc.LibraryUserId)
                .IsRequired(false);

            builder.HasOne(lu => lu.BookLend)
                .WithOne(bl => bl.LibraryUser)
                .HasForeignKey<BookLend>(bl => bl.LibraryUserId)
                .IsRequired(false);

            builder.Property(lu => lu.Name)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(lu => lu.EmailAddress)
                .IsRequired()
                .HasMaxLength(254);

            builder.Property(lu => lu.PhoneNumber)
                .IsRequired()
                .HasMaxLength(100);
        }
    }
}
