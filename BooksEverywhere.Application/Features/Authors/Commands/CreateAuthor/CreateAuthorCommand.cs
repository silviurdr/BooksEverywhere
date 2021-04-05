using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.Authors.Commands.CreateAuthor
{
    public class CreateAuthorCommand: IRequest<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
