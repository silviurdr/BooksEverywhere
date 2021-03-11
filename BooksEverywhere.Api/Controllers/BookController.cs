using BooksEverywhere.Application.Features.Books.Commands;
using BooksEverywhere.Application.Features.Books.Commands.CreateBook;
using BooksEverywhere.Application.Features.Events;
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
    public class BookController: ControllerBase
    {
        private readonly IMediator _mediator;

        public BookController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all", Name="GetAllBooks")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<BookListVm>>> GetAllBooks()
        {
            var dtos = await _mediator.Send(new GetBooksListQuery());
            return Ok(dtos);
        }

        [HttpGet("id", Name = "GetBookById")]
        public async Task<ActionResult<BookInfoVm>> GetBookById(int id)
        {
            var getBookInfoQuery = new GetBookInfoQuery() { Id = id };
            return Ok(await _mediator.Send(getBookInfoQuery));
        }

        [HttpPost(Name = "AddBook")]
        public async Task<ActionResult<CreateBookCommandResponse>> Create([FromBody]CreateBookCommand createBookCommand)
        {
            var response = await _mediator.Send(createBookCommand);
            return Ok(response);
        }

    }
}
