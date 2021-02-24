using BooksEverywhere.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.Stacks.Queries.GetStackInfo
{
    public class StackInfoVm
    {
        public int Id { get; set; }
        public string StackCode { get; set; }
        public StackTag StackTag { get; set; }
        public ICollection<Shelf> Shelves { get; set; }
    }
}
