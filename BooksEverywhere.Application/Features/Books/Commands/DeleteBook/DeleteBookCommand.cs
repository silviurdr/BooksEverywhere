using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.Books.Commands.DeleteBook
{
    public class DeleteBookCommand: IRequest
    {
        public int Id { get; set; }
    }
}
