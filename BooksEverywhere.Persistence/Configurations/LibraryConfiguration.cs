using BooksEverywhere.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Persistence.Configurations
{
    class LibraryConfiguration : IEntityTypeConfiguration<Library>
    {
        public void Configure(EntityTypeBuilder<Library> builder)
        {
            builder.HasOne(l => l.libraryInfo)
                .WithOne(li => li.Library)
                .HasForeignKey<LibraryInfo>(li => li.LibraryId);

            builder.HasMany(l => l.BooksCollection)
                .WithOne(bc => bc.Library)
                .HasForeignKey(bc => bc.LibraryId);

            builder.HasMany(l => l.Users)
                .WithOne(lu => lu.Library)
                .HasForeignKey(bc => bc.LibraryId);

            builder.HasMany(l => l.Subsidiaries)
                .WithOne(s => s.Library)
                .HasForeignKey(s => s.LibraryId);

            builder.HasMany(l => l.Subsidiaries)
                .WithOne(s => s.Library)
                .HasForeignKey(s => s.LibraryId);

            builder.HasMany(l => l.Rooms)
                .WithOne(r => r.Library)
                .HasForeignKey(r => r.LibraryId);

        }
    }
}
