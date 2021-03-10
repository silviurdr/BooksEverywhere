using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Domain.Entities
{
    public class LibraryInfo
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Schedule { get; set; }
        public ICollection<Room> Rooms { get; set; }
        public Library Library { get; set; }
        public int LibraryId { get; set; }
    }
}
