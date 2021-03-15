using BooksEverywhere.Application.Interfaces.Persistence;
using BooksEverywhere.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Persistence.Repositories
{
    public class LibraryUserRepository: BaseRepository<LibraryUser>, ILibraryUserRepository
    {
        public LibraryUserRepository(BooksEverywhereDbContext dbContext): base(dbContext)
        {

        }
    }
}
