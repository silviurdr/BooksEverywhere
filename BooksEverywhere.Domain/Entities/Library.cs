using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Domain.Entities
{
    public class Library
    {
        public int Id { get; set; }
        public LibraryInfo libraryInfo { get; set; }
        public ICollection<Subsidiary> Subsidiaries { get; set; }
        public ICollection<BookCollection> BooksCollection { get; set; }
        public ICollection<LibraryUser> Users { get; set; }
    }
}
