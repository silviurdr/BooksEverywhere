using BooksEverywhere.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.Libraries.Queries.GetLibraryInfo
{
    public class LibraryInfoVm
    {
        public int Id { get; set; }
        public LibraryInfo libraryInfo { get; set; }
    }
}
