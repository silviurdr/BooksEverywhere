using BooksEverywhere.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.LibraryUsers.Queries.GetLibraryUsersList
{
    public class LibraryUsersListVm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public UserType UserType { get; set; }
    }
}
