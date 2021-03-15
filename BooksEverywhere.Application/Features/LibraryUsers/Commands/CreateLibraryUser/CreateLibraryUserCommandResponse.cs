using BooksEverywhere.Application.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.LibraryUsers.Commands.CreateLibraryUser
{
    public class CreateLibraryUserCommandResponse: BaseResponse
    {
        public CreateLibraryUserCommandResponse(): base()
        {

        }

        public CreateLibraryUserDto LibraryUser { get; set; }
    }
}
