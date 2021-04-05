using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.Authors.Commands.CreateAuthor
{
    public class CreateAuthorDto
    {
        public int AuthorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
