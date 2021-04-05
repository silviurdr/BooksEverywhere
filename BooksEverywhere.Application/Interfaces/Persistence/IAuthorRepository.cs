using BooksEverywhere.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BooksEverywhere.Application.Interfaces.Persistence
{
    public interface IAuthorRepository: IAsyncRepository<Author>
    {
        Task<Author> GetAuthorByName(string fullName);
    }
}
