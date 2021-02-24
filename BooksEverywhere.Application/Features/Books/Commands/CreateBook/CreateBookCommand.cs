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
        public BookStatus BookStatus { get; set; }
        public BooksCollection BookCollection { get; set; }
        public BookDetails Details { get; set; }
    }
}
