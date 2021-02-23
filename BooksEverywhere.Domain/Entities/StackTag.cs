using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Domain.Entities
{
    public class StackTag
    {
        public int Id { get; set; }
        public Subject Subject { get; set; }
        public string BooksRange { get; set; }
    }
}
