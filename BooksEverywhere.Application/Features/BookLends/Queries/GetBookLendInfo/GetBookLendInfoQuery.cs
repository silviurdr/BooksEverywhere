using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.BookLends.Queries.GetBookLendInfo
{
    class GetBookLendInfoQuery : IRequest
    {
        public int Id { get; set; }
    }
}
