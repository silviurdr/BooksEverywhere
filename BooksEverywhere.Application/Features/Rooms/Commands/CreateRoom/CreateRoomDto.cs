using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.Rooms.Commands.CreateRoom
{
    public class CreateRoomDto
    {
        public int RoomId { get; set; }
        public string Name { get; set; }
    }
}
