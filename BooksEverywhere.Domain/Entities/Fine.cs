using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Domain.Entities
{
    public class Fine
    {
        public int Id { get; set; }
        public int BookLendId { get; set; }
        public double Amount { get; set; }
        public LendStatus LendStatus { get; set; }
    }
}
