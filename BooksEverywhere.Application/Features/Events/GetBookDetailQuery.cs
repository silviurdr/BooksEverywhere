using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.Events
{
    class GetBookDetailQuery: IRequest<BookDetailVm>
    {
        public int Id { get; set; }
    }
}
