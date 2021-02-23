using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Domain.Entities
{
    public class Librarian
    {
        public int Id { get; set; }
        public int CardId { get; set; }
        public int UserId { get; set; }
    }
}
