using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.Rooms.Queries.GetRoomsList
{
    public class GetRoomsListQuery: IRequest<List<RoomsListVm>>
    {
    }
}
