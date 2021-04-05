using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.Authors.Queries.GetAuthorInfo
{
    public class AuthorInfoVm
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
