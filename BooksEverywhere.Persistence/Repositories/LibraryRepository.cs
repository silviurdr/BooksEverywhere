using BooksEverywhere.Application.Interfaces.Persistence;
using BooksEverywhere.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksEverywhere.Persistence.Repositories
{
    public class LibraryRepository: BaseRepository<Library>, ILibraryRepository
    {
        public LibraryRepository(BooksEverywhereDbContext dbContext): base(dbContext)
        {

        }

        public async override Task<Library> GetByIdAsync(int id)
        {
            return await _dbContext.Libraries.Include(l => l.libraryInfo).FirstOrDefaultAsync(l => l.Id == id);
        }
    }
}
