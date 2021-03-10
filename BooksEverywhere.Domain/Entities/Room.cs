using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Domain.Entities
{
    public class Room
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Stack> Stacks { get; set; }
        public Library Library { get; set; }
        public int LibraryId { get; set; }
    }
}
