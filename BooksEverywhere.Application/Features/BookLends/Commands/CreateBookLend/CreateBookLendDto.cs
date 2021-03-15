using BooksEverywhere.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.BookLends.Commands.CreateBookLend
{
    public class CreateBookLendDto
    {
        public int Id { get; set; }
        public ICollection<Book> BooksList { get; set; }

        public int LibraryUserId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime DueDate { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}
