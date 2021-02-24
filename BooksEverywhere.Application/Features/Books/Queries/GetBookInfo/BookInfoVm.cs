using BooksEverywhere.Domain.Entities;
using BooksEverywhere.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.Events
{
    public class BookInfoVm
    {
        public int Id { get; set; }
        public BookStatus BookStatus { get; set; }
        public BookCollection BookCollection { get; set; }
        public BookDetails Details { get; set; }
    }
}
