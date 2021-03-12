using BooksEverywhere.Application.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.BookCollections.Queries.GetBookCollectionList
{
    public class CreateBookCollectionCommandResponse: BaseResponse
    {
        public CreateBookCollectionCommandResponse() : base()
        {

        }

        public CreateBookCollectionDto BookCollection { get; set; }
    }
}
