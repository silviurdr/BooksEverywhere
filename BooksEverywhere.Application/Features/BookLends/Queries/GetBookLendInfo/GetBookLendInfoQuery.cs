using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.BookLends.Queries.GetBookLendInfo
{
    public class GetBookLendInfoQuery : IRequest<BookLendInfoVm>
    {
        public int Id { get; set; }
    }
}
