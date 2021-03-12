using BooksEverywhere.Application.Features.BookCollections.Commands.CreateBookCollection;
using BooksEverywhere.Application.Features.BookCollections.Commands.DeleteBookCollection;
using BooksEverywhere.Application.Features.BookCollections.Commands.UpdateBookCollection;
using BooksEverywhere.Application.Features.BookCollections.Queries.GetBookCollectionList;
using BooksEverywhere.Application.Features.BookCollections.Queries.GetBookCollectionsList;
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
    public class BookCollectionController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BookCollectionController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all", Name = "GetAllBookCollections")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<BookCollectionListVm>>> GetAllBookCollections()
        {
            var dtos = await _mediator.Send(new GetBookCollectionListQuery());

            return dtos;
        }

        [HttpGet("id", Name = "GetBookCollectionById")]
        public async Task<ActionResult<BookCollectionListVm>> GetBookCollectionById(int id)
        {
            var getBookCollectionInfoQuery = new GetBookCollectionInfoQuery() { Id = id };
            return Ok(await _mediator.Send(getBookCollectionInfoQuery));
        }

        [HttpPost(Name = "AddBookCollection")]
        public async Task<ActionResult<CreateBookCollectionCommandResponse>> Create([FromBody] CreateBookCollectionCommand createBookCollectionCommand)
        {
            var response = await _mediator.Send(createBookCollectionCommand);

            return Ok(response);
        }

        [HttpPut("id", Name = "UpdateBookCollection")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Update([FromBody] UpdateBookCollectionCommand updateBookCollectionCommand)
        {
            await _mediator.Send(updateBookCollectionCommand);

            return NoContent();
        }

        [HttpDelete("id", Name = "DeleteBookCollection")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Delete(int id)
        {
            var deleteBookCollectionCommand = new DeleteBookCollectionCommand() { Id = id };
            await _mediator.Send(deleteBookCollectionCommand);

            return NoContent();
        }

    }
}
