using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.Rooms.Commands.DeleteRoom
{
    public class DeleteRoomCommand: IRequest
    {
        public int Id { get; set; }
    }
}
