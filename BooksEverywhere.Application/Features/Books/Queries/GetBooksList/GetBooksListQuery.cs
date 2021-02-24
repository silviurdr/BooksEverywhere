using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.Events
{
    public class GetBooksListQuery: IRequest<List<BookListVm>>
    {
    }
}
