using BooksEverywhere.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.Libraries.Commands.UpdateLibrary
{
    public class UpdateLibraryCommand: IRequest
    {
        public int Id { get; set; }
        public LibraryInfo libraryInfo { get; set; }
    }
}
