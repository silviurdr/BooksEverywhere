using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.LibraryUsers.Commands.DeleteLibraryUser
{
    public class DeleteLibraryUserCommand: IRequest
    {
        public int Id { get; set; }
    }
}
