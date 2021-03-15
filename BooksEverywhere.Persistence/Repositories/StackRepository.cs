using BooksEverywhere.Application.Interfaces.Persistence;
using BooksEverywhere.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Persistence.Repositories
{
    public class StackRepository: BaseRepository<Stack>, IStackRepository
    {
        public StackRepository(BooksEverywhereDbContext dbContext): base(dbContext)
        {

        }
    }
}
