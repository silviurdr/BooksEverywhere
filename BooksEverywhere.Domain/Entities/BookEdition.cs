using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Domain.Entities
{
    public class BookEdition
    {
        public int Id { get; set; }
        public string ISBN { get; set; }
        public string Language { get; set; }
        public string PublishedYear { get; set; }
        public int Copies { get; set; }
        public string CoverImage { get; set; }

    }
}
