using BooksEverywhere.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Interfaces.Persistence
{
    public interface ILibraryUserRepository: IAsyncRepository<LibraryUser>
    {
    }
}
