using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.Authors.Queries.GetAuthorsList
{
    public class GetAuthorListQuery: IRequest<List<AuthorListVm>>
    {
    }
}
