using BooksEverywhere.Application.Interfaces.Persistence;
using BooksEverywhere.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Persistence.Repositories
{
    public class SubjectRepository: BaseRepository<Subject>, ISubjectRepository
    {
        public SubjectRepository(BooksEverywhereDbContext dbContext) : base(dbContext)
        {

        }
    }
}
