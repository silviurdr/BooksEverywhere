using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.Stacks.Commands.DeleteStack
{
    public class DeleteStackCommand: IRequest
    {
        public int Id { get; set; }
    }
}
