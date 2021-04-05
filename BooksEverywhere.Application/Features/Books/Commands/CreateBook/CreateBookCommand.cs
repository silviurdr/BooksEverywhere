using BooksEverywhere.Domain.Entities;
using BooksEverywhere.Domain.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.Books.Commands
{
    public class CreateBookCommand: IRequest<int>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public Author Author { get; set; }
    }
}
