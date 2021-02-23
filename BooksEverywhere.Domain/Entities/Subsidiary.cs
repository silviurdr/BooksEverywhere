using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Domain.Entities
{
    public class Subsidiary
    {
        public int Id { get; set; }
        public LibraryInfo LibraryInfo { get; set; }
    }
}
