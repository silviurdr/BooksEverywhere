using BooksEverywhere.Application.Interfaces.Persistence;
using BooksEverywhere.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BooksEverywhere.Persistence.Repositories
{
    public class SubsidiaryRepository: BaseRepository<Subsidiary>, ISubsidiaryRepository
    {
        public SubsidiaryRepository(BooksEverywhereDbContext dbContext): base(dbContext)
        {
            
        }

        public async override Task<IReadOnlyList<Subsidiary>> ListAllAsync()
        {
            return await _dbContext.Subsidiaries.Include(s => s.LibraryInfo).ToListAsync();
        }

        public async override Task<Subsidiary> GetByIdAsync(int id)
        {
            return await _dbContext.Subsidiaries.Include(s => s.LibraryInfo).FirstOrDefaultAsync(s => s.Id == id);
        }

    }
}
