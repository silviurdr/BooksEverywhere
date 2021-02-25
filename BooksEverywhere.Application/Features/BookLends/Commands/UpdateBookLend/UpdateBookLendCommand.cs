using BooksEverywhere.Domain.Entities;
using BooksEverywhere.Domain.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.BookLends.Commands.UpdateBookLend
{
    public class UpdateBookLendCommand: IRequest
    {
        public int Id { get; set; }
        public BookStatus BookStatus { get; set; }
        public BookCollection BookCollection { get; set; }
        public BookDetails Details { get; set; }
    }
}
