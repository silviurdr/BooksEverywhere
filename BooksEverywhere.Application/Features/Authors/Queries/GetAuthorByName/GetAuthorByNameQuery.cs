using BooksEverywhere.Application.Features.Authors.Queries.GetAuthorByName;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.Authors.Queries.GetAuthorIdByAuthorName
{
    public class GetAuthorByNameQuery: IRequest<AuthorByNameVm>
    {
        public string FullName { get; set; }
    }
}
