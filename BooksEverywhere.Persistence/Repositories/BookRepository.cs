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
            return await _dbContext.Books.ToListAsync();
        }

        public async override Task<Book> GetByIdAsync(int id)
        {
            return await _dbContext.Books.FirstOrDefaultAsync(b => b.Id == id);
        }

    }
}
