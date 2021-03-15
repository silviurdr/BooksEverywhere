using BooksEverywhere.Application.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.BookLends.Commands.CreateBookLend
{
    public class CreateBookLendCommandResponse: BaseResponse
    {
        public CreateBookLendCommandResponse(): base()
        {

        }

        public CreateBookLendDto BookLend { get; set; }
    }
}
