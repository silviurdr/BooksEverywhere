using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Domain.Entities
{
    public class Member
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime JoinDate { get; set; }
        public int BooksAllowed { get; set; }
        public int BooksLoaned { get; set; }
    }
}
