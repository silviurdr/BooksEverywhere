using BooksEverywhere.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.Rooms.Commands.CreateRoom
{
    public class CreateRoomCommand: IRequest<int>
    {
        public string Name { get; set; }
        public ICollection<Stack> Stacks { get; set; }
    }
}
