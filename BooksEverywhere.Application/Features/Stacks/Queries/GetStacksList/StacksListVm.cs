using BooksEverywhere.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.Stacks.Queries.GetStacksList
{
    public class StacksListVm
    {
        public int Id { get; set; }
        public string StackCode { get; set; }
        public StackTag StackTag { get; set; }
        public ICollection<Shelf> Shelves { get; set; }
    }
}
