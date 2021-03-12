using BooksEverywhere.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.BookCollections.Queries.GetBookCollectionList
{
    public class CreateBookCollectionDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int LibraryId { get; set; }
    }
}
