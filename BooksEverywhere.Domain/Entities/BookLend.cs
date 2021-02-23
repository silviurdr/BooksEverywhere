using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Domain.Entities
{
    public class BookLend
    {
        public int Id { get; set; }
        public ICollection<Book> BooksList { get; set; }
        public int MemberId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public ICollection<Notification> Notifications { get; set; }
        public Fine Fine { get; set; }
    }
}
