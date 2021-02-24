using BooksEverywhere.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.Libraries.Commands.CreateLibrary
{
    public class CreateLibraryCommand: IRequest<int>
    {
        public LibraryInfo libraryInfo { get; set; }
    }
}
