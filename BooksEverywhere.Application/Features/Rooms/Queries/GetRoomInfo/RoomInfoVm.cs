using BooksEverywhere.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.Rooms.Queries.GetRoomInfo
{
    public class RoomInfoVm
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Stack> Stacks { get; set; }
    }
}
