using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Domain.Entities
{
    public class Shelf
    {
        public int Id { get; set; }
        public string ShelfCode { get; set; }
        public ICollection<Book> Books { get; set; }
    }
}
