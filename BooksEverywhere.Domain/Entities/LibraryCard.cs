using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Domain.Entities
{
    public class LibraryCard
    {
        public int Id { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public LibraryUser LibraryUser { get; set; }
        public int LibraryUserId { get; set; }
    }
}
