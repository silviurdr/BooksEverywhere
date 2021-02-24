using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.Libraries.Queries.GetLibraryInfo
{
    class GetLibraryInfoQuery: IRequest<LibraryInfoVm>
    {
        public int Id { get; set; }
    }
}
