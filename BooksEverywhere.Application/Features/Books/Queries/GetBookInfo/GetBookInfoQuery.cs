using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.Events
{
    class GetBookInfoQuery: IRequest<BookInfoVm>
    {
        public int Id { get; set; }
    }
}
