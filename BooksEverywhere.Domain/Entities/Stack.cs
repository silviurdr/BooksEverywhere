using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Domain.Entities
{
    public class Stack
    {
        public int Id { get; set; }
        public string StackCode { get; set; }
        public StackTag StackTag { get; set; }
        public ICollection<Shelf> Shelves { get; set; }
    }
}
