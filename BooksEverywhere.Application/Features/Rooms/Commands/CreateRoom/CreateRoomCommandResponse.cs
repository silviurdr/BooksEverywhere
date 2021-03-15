using BooksEverywhere.Application.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.Rooms.Commands.CreateRoom
{
    public class CreateRoomCommandResponse: BaseResponse
    {
        public CreateRoomCommandResponse(): base()
        {

        }

        public CreateRoomDto Room { get; set; }
    }
}
