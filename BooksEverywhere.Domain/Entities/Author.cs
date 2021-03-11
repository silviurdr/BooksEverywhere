using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Domain.Entities
{
    public class Author
    {
        public int Id { get; set; }
        public string AuthorCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BookDetailsId { get; set; }
    }
}
