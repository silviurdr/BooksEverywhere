using BooksEverywhere.Application.Interfaces.Persistence;
using BooksEverywhere.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BooksEverywhere.Persistence.Repositories
{
    public class BookRepository : BaseRepository<Book>, IBookRepository
    {

        public BookRepository(BooksEverywhereDbContext dbContext): base(dbContext)
        {

        }

        public async override Task<IReadOnlyList<Book>> ListAllAsync()
        {
            var allBooks =  await _dbContext.Books.Include(b => b.BookDetails).ToListAsync();

            return allBooks;
        }
    }
}
