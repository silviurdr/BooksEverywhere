using BooksEverywhere.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Domain.Entities
{
    public class LibraryUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Photo { get; set; }
        public UserType UserType { get; set; }
        public Account Account { get; set; }
        public LibraryCard LibraryCard { get; set; }
        public BookLend BookLend { get; set; }
    }
}
