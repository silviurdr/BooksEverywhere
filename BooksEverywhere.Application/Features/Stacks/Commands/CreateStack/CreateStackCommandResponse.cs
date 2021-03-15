using BooksEverywhere.Application.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.Stacks.Commands.CreateStack
{
    public class CreateStackCommandResponse: BaseResponse
    {
        public CreateStackCommandResponse(): base()
        {

        }

        public CreateStackDto Stack { get; set; }
    }
}
