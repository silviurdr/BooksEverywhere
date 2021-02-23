using BooksEverywhere.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Domain.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public BookStatus BookStatus { get; set; }
        public BooksCollection BookCollection { get; set; }
        public BookDetails Details { get; set; }
        public BookCallNumber BookCallNumber { get; set; }
    }
}
