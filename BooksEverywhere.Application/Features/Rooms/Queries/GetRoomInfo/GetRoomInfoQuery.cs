using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.Rooms.Queries.GetRoomInfo
{
    public class GetRoomInfoQuery: IRequest<RoomInfoVm>
    {
        public int Id { get; set; }
    }
}
