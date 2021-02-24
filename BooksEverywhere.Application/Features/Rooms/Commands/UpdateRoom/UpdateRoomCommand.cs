using BooksEverywhere.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.Rooms.Commands.UpdateRoom
{
    public class UpdateRoomCommand: IRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Stack> Stacks { get; set; }
    }
}
