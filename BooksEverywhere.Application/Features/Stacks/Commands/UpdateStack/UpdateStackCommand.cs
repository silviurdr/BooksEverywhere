using BooksEverywhere.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.Stacks.Commands.UpdateStack
{
    public class UpdateStackCommand: IRequest
    {
        public int Id { get; set; }
        public string StackCode { get; set; }
    }
}
