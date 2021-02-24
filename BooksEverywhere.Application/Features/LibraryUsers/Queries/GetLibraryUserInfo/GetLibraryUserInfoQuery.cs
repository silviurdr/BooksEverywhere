using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.LibraryUsers.Queries.GetLibraryUserInfo
{
    public class GetLibraryUserInfoQuery: IRequest<LibraryUserInfoVm>
    {
        public int Id { get; set; }
    }
}
