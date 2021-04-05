using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.Authors.Queries.GetAuthorInfo
{
    public class GetAuthorInfoQuery: IRequest<AuthorInfoVm>
    {
        public int Id { get; set; }
    }
}
