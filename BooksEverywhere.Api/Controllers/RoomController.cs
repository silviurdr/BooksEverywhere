using BooksEverywhere.Application.Features.Books.Commands.UpdateBook;
using BooksEverywhere.Application.Features.Rooms.Commands.CreateRoom;
using BooksEverywhere.Application.Features.Rooms.Commands.DeleteRoom;
using BooksEverywhere.Application.Features.Rooms.Queries.GetRoomInfo;
using BooksEverywhere.Application.Features.Rooms.Queries.GetRoomsList;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksEverywhere.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomController : ControllerBase
    {
        private readonly IMediator _mediator;

        public RoomController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all", Name = "GetAllRooms")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<RoomsListVm>>> GetAllRooms()
        {
            var dtos = await _mediator.Send(new GetRoomsListQuery());
            return Ok(dtos);
        }

        [HttpGet("id", Name = "GetRoomById")]
        public async Task<ActionResult<RoomInfoVm>> GetRoomById(int id)
        {
            var getRoomInfoQuery = new GetRoomInfoQuery() { Id = id };
            return Ok(await _mediator.Send(getRoomInfoQuery));
        }

        [HttpPost(Name = "AddRoom")]
        public async Task<ActionResult<int>> CreateRoom([FromBody] CreateRoomCommand createRoomCommand)
        {
            var response = await _mediator.Send(createRoomCommand);
            return Ok(response);
        }

        [HttpPut("id", Name = "UpdateRoom")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> UpdateRoom([FromBody] UpdateBookCommand updateBookCoomand)
        {
            await _mediator.Send(updateBookCoomand);
            return NoContent();
        }

        [HttpDelete("id", Name = "DeleteRoom")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> DeleteRoom(int id)
        {
            var deleteRoomCommand = new DeleteRoomCommand() { Id = id };
            await _mediator.Send(deleteRoomCommand);
            return NoContent();
        }
    }
}
