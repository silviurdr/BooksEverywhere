using BooksEverywhere.Application.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.Books.Commands.CreateBook
{
    public class CreateBookCommandResponse : BaseResponse
    {
        public CreateBookCommandResponse() : base()
        {

        }

        public CreateBookDto Book { get; set; }
    }
}
