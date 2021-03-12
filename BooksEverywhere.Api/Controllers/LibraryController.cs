using BooksEverywhere.Application.Features.Libraries.Commands.CreateLibrary;
using BooksEverywhere.Application.Features.Libraries.Commands.DeleteLibrary;
using BooksEverywhere.Application.Features.Libraries.Commands.UpdateLibrary;
using BooksEverywhere.Application.Features.Libraries.Queries.GetLibraryInfo;
using BooksEverywhere.Domain.Entities;
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
    public class LibraryController : ControllerBase
    {
        private readonly IMediator _mediator;

        public LibraryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("id", Name = "GetLibraryById")]
        public async Task<ActionResult<Library>> GetLibraryById(int id)
        {
            var getLibraryInfoQuery = new GetLibraryInfoQuery() { Id = id };

            return Ok(await _mediator.Send(getLibraryInfoQuery));
        }

        [HttpPost(Name = "CreateLibrary")]
        public async Task<ActionResult<int>> Create([FromBody] CreateLibraryCommand createLibraryCommandQuery)
        {
            var response = await _mediator.Send(createLibraryCommandQuery);

            return Ok(response);
        }

        [HttpPut("id", Name = "UpdateLibrary")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Update([FromBody] UpdateLibraryCommand updateLibraryCommand)
        {
            await _mediator.Send(updateLibraryCommand);

            return NoContent();
        }

        [HttpDelete("id", Name = "DeleteLibrary")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Delete(int id)
        {
            var deleteLibraryCommand = new DeleteLibraryCommand() { Id = id };
            await _mediator.Send(deleteLibraryCommand);

            return NoContent();
        }
    }
}
