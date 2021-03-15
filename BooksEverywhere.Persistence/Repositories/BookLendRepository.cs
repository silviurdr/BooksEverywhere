using BooksEverywhere.Application.Interfaces.Persistence;
using BooksEverywhere.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Persistence.Repositories
{
    public class BookLendRepository: BaseRepository<BookLend>, IBookLendRepository
    {
        public BookLendRepository(BooksEverywhereDbContext dbContext): base(dbContext)
        {         
        }
    }
}
