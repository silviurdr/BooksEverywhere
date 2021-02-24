using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Domain.Entities
{
    public class BookDetails
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Author Author { get; set; }
        public ICollection<Subject> Subjects { get; set; }
        public string Description { get; set; }
        
    }
}
