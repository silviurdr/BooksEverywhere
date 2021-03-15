using BooksEverywhere.Application.Features.LibraryUsers.Commands.CreateLibraryUser;
using BooksEverywhere.Application.Features.LibraryUsers.Commands.DeleteLibraryUser;
using BooksEverywhere.Application.Features.LibraryUsers.Commands.UpdateLibraryUser;
using BooksEverywhere.Application.Features.LibraryUsers.Queries.GetLibraryUserInfo;
using BooksEverywhere.Application.Features.LibraryUsers.Queries.GetLibraryUsersList;
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
    public class LibraryUserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public LibraryUserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all", Name = "GetAllLibraryUsers")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<LibraryUsersListVm>>> GetAllLibraryUsers()
        {
            var dtos = await _mediator.Send(new GetLibraryUsersListQuery());
            return Ok(dtos);
        }

        [HttpGet("id", Name = "GetLibraryUserById")]
        public async Task<ActionResult<LibraryUserInfoVm>> GetLibraryUserById(int id)
        {
            var getLibraryUserInfoQuery = new GetLibraryUserInfoQuery() { Id = id };
            return Ok(await _mediator.Send(getLibraryUserInfoQuery));
        }

        [HttpPost(Name = "AddLibraryUser")]
        public async Task<ActionResult<int>> CreateLibraryUser([FromBody] CreateLibraryUserCommand createLibraryUserCommand)
        {
            var response = await _mediator.Send(createLibraryUserCommand);
            return Ok(response);
        }

        [HttpPut("id", Name = "UpdateLibraryUser")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> UpdateLibraryUser([FromBody] UpdateLibraryUserCommand updateLibraryUserCommand)
        {
            await _mediator.Send(updateLibraryUserCommand);
            return NoContent();
        }

        [HttpDelete("id")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> DeleteLibrary(int id)
        {
            var deleteLibraryUserCommand = new DeleteLibraryUserCommand() { Id = id };
            await _mediator.Send(deleteLibraryUserCommand);

            return NoContent();
        }

    }
}
