using BooksEverywhere.Application.Features.Authors.Commands.CreateAuthor;
using BooksEverywhere.Application.Features.Authors.Commands.DeleteAuthor;
using BooksEverywhere.Application.Features.Authors.Commands.UpdateAuthor;
using BooksEverywhere.Application.Features.Authors.Queries.GetAuthorInfo;
using BooksEverywhere.Application.Features.Authors.Queries.GetAuthorsList;
using BooksEverywhere.Application.Features.Books.Commands.UpdateBook;
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
    public class AuthorController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AuthorController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all", Name="GetAllAuthors")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<AuthorListVm>>> GetAllAuthors()
        {
            var dtos = await _mediator.Send(new GetAuthorListQuery());

            return dtos;
        }

        [HttpGet("id", Name="GetAuthorById")]
        public async Task<ActionResult<AuthorInfoVm>> GetAuthorById(int id)
        {
            var getAuthorInfoQuery = new GetAuthorInfoQuery() { Id = id };
            return Ok(await _mediator.Send(getAuthorInfoQuery));
        }

        [HttpPost(Name="AddAuthor")]
        public async Task<ActionResult<int>> Create([FromBody] CreateAuthorCommand createAuthorCommand)
        {
            var response = await _mediator.Send(createAuthorCommand);
            return Ok(response);
        }

        [HttpPut("id", Name="UpdateAuthor")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> UpdateAuthor([FromBody] UpdateAuthorCommand updateAuthorCommand)
        {
            await _mediator.Send(updateAuthorCommand);
            return NoContent();
        }

        [HttpDelete(Name="DeleteAuthor")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> DeleteBook(int id)
        {
            var deleteAuthorCommand = new DeleteAuthorCommand() { Id = id };
            await _mediator.Send(deleteAuthorCommand);
            return NoContent();
        }

    }
}
