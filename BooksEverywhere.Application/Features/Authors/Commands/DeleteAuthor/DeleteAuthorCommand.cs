using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.Authors.Commands.DeleteAuthor
{
    public class DeleteAuthorCommand: IRequest
    {
        public int Id{ get; set; }
    }
}
