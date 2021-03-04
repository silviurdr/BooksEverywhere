using BooksEverywhere.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Persistence
{
    public class BooksEverywhereDbContext: DbContext
    {

        public BooksEverywhereDbContext(DbContextOptions<BooksEverywhereDbContext> options)
            : base(options)
        {
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookCollection> BookCollections { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(BooksEverywhereDbContext).Assembly);
        }
    }
}
