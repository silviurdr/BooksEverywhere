using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Domain.Entities
{
    public class BookTag
    {
        public int Id { get; set; }
        public int BookNumber { get; set; }
        public string AuthorCode { get; set; }
        public int PublishedYear { get; set; }
        public string Copy { get; set; }
        public string VolumeNumber { get; set; }
        public Book Book { get; set; }
        public int BookId { get; set; }
    }
}
