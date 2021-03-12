using BooksEverywhere.Domain.Entities;
using BooksEverywhere.Domain.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.Books.Commands.UpdateBook
{
    public class UpdateBookCommand: IRequest
    {
        public int Id { get; set; }
        public BookStatus BookStatus { get; set; }
        public BookDetails BookDetails { get; set; }
    }
}
