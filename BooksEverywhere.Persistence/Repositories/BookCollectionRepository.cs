using BooksEverywhere.Application.Interfaces.Persistence;
using BooksEverywhere.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BooksEverywhere.Persistence.Repositories
{
    public class BookCollectionRepository : BaseRepository<BookCollection>, IBookCollectionRepository
    {
        public BookCollectionRepository(BooksEverywhereDbContext dbContext) : base(dbContext)
        {

        }

    }
}
