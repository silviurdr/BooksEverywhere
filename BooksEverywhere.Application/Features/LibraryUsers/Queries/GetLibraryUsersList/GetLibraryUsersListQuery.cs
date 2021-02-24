using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.LibraryUsers.Queries.GetLibraryUsersList
{
    public class GetLibraryUsersListQuery: IRequest<List<LibraryUsersListVm>>
    {
    }
}
