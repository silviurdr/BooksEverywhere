using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Domain.Entities
{
    public class BookCollection
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Room RoomLocation { get; set; }
    }
}
