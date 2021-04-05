using BooksEverywhere.Application.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.Authors.Commands.CreateAuthor
{
    public class CreateAuthorCommandResponse: BaseResponse
    {
        public CreateAuthorCommandResponse(): base()
        {

        }
        public CreateAuthorDto Author { get; set; }
    }
}
