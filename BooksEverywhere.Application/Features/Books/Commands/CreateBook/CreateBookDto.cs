﻿using BooksEverywhere.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.Books.Commands.CreateBook
{
    public class CreateBookDto
    {
        public int BookId { get; set; }
        public BookDetails BookDetails { get; set; }
    }
}