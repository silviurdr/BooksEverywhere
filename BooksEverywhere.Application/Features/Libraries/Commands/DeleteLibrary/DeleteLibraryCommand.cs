using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.Libraries.Commands.DeleteLibrary
{
    public class DeleteLibraryCommand: IRequest
    {
        public int Id { get; set; }
    }
}
