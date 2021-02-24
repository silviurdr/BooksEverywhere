using BooksEverywhere.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Interfaces.Persistence
{
    interface ILibraryUserRepository: IAsyncRepository<LibraryUser>
    {
    }
}
