using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Domain.Entities
{
    public class BookCallNumber
    {
        public int Id { get; set; }
        public Subject Subject { get; set; }
        public string AuthorReference { get; set; }
        public string PublishedYear { get; set; }
    }
}
