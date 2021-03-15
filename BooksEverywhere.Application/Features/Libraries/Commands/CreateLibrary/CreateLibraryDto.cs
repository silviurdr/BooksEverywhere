using BooksEverywhere.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.Libraries.Commands.CreateLibrary
{
    public class CreateLibraryDto
    {
        public LibraryInfo LibraryInfo { get; set; }
    }
}
