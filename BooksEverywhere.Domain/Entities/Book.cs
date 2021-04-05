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
        public BookCollection BookCollection { get; set; }
        public BookTag BookTag { get; set; }
        public BookCallNumber BookCallNumber { get; set; }
        public string Title { get; set; }
        public Author Author { get; set; }
        public int AuthorId { get; set; }
        public ICollection<Subject> Subjects { get; set; }
        public string Description { get; set; }
        public ICollection<BookEdition> BookEditions { get; set; }
    }
}
