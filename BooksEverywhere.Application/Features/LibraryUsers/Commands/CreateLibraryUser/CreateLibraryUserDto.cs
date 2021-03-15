using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.LibraryUsers.Commands.CreateLibraryUser
{
    public class CreateLibraryUserDto
    {
        public int LibraryUserId { get; set; }
        public string Name { get; set; }
    }
}
