using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.BookLends.Queries.GetBookLendsList
{
    public class GetBookLendsListQuery: IRequest<List<BookLendListVm>>
    {
    }
}
