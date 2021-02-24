using BooksEverywhere.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.Stacks.Commands.CreateStack
{
    public class CreateStackCommand: IRequest<int>
    {
        public string StackCode { get; set; }
        public StackTag StackTag { get; set; }
        public ICollection<Shelf> Shelves { get; set; }
    }
}
