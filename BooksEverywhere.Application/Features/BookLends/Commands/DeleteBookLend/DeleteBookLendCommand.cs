using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.BookLends.Commands.DeleteBookLend
{
    public class DeleteBookLendCommand : IRequest
    {
        public int Id { get; set; }
    }
}
