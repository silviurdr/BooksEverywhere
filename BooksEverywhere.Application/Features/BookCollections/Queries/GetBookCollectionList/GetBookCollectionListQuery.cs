using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.BookCollections.Queries.GetBookCollectionList
{
    public class GetBookCollectionListQuery: IRequest<List<BookCollectionListVm>>
    {
    }
}
