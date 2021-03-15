using BooksEverywhere.Application.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.Libraries.Commands.CreateLibrary
{
    public class CreateLibraryCommandResponse: BaseResponse
    {
        public CreateLibraryCommandResponse(): base()
        {

        }

        public CreateLibraryDto Library { get; set; }
    }
}
