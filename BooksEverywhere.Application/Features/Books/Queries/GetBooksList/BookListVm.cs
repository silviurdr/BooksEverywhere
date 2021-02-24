using BooksEverywhere.Domain.Entities;
using BooksEverywhere.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.Events
{
    public class BookListVm
    {
        public int Id { get; set; }
        public BookStatus BookStatus { get; set; }
        public BooksCollection BookCollection { get; set; }
        public BookDetails Details { get; set; }
    }
}
