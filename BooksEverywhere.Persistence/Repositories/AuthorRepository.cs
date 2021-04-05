using BooksEverywhere.Application.Interfaces.Persistence;
using BooksEverywhere.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BooksEverywhere.Persistence.Repositories
{
    public class AuthorRepository: BaseRepository<Author>, IAuthorRepository
    {
        private readonly BooksEverywhereDbContext _dbContext;

        public AuthorRepository(BooksEverywhereDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async override Task<Author> GetByIdAsync(int id)
        {
            return await _dbContext.Authors.Include(a => a.Books).FirstOrDefaultAsync(a => a.Id == id);
        }

        public async Task<Author> GetAuthorByName(string fullName)
        {
            return await _dbContext.Authors.Include(a => a.Books).FirstOrDefaultAsync(a => a.FirstName + " " + a.LastName == fullName);
        }
    }
}
