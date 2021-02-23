using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Domain.Entities
{
    public class Notification
    {
        public int Id { get; set; }
        public decimal CreatedOn { get; set; }
        public string Content { get; set; }
        public int BookLendId { get; set; }
    }
}
