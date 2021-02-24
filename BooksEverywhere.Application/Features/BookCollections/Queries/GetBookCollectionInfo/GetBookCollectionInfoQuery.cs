using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.BookCollections.Queries.GetBookCollectionsList
{
    public class GetBookCollectionInfoQuery: IRequest<BookCollectionInfoVm>
    {
        public int Id { get; set; }
    }
}
