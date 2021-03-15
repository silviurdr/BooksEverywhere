using BooksEverywhere.Application.Features.BookLends.Commands.CreateBookLend;
using BooksEverywhere.Application.Features.BookLends.Commands.DeleteBookLend;
using BooksEverywhere.Application.Features.BookLends.Commands.UpdateBookLend;
using BooksEverywhere.Application.Features.BookLends.Queries.GetBookLendInfo;
using BooksEverywhere.Application.Features.BookLends.Queries.GetBookLendsList;
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
    public class BookLendsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BookLendsController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet("all", Name = "GetAllBookLends")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<BookLendListVm>>> GetAllBookLends()
        {
            var dtos = await _mediator.Send(new GetBookLendsListQuery());
            return Ok(dtos);
        }

        [HttpGet("id", Name = "GetBookLendById")]
        public async Task<ActionResult<BookLendInfoVm>> GetBookLendById(int id)
        {
            var getBookLendInfoQuery = new GetBookLendInfoQuery() { Id = id };

            return Ok(await _mediator.Send(getBookLendInfoQuery));
        }

        [HttpPost(Name = "AddBookLend")]
        public async Task<ActionResult<int>> CreateBookLend([FromBody] CreateBookLendCommand createBookLendCommand)
        {
            var response = await _mediator.Send(createBookLendCommand);
            return Ok(response);
        }

        [HttpPut("id", Name = "UpdateBookLend")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> UpdateBookLend([FromBody] UpdateBookLendCommand updateBookLendCommand)
        {
            await _mediator.Send(updateBookLendCommand);

            return NoContent();
        }

        [HttpDelete("id", Name = "DeleteBookLend")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Delete(int id)
        {
            var deleteBookLendCommandQuery = new DeleteBookLendCommand() { Id = id };
            await _mediator.Send(deleteBookLendCommandQuery);

            return NoContent();
        }
    }
}
