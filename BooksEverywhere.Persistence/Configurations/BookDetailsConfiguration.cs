using BooksEverywhere.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Persistence.Configurations
{
    public class BookDetailsConfiguration : IEntityTypeConfiguration<BookDetails>
    {
        public void Configure(EntityTypeBuilder<BookDetails> builder)
        {
            builder.Ignore(bd => bd.Book);
        }
    }
}
