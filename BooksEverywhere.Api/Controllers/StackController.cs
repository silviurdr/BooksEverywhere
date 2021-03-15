using BooksEverywhere.Application.Features.Stacks.Commands.CreateStack;
using BooksEverywhere.Application.Features.Stacks.Commands.DeleteStack;
using BooksEverywhere.Application.Features.Stacks.Commands.UpdateStack;
using BooksEverywhere.Application.Features.Stacks.Queries.GetStackInfo;
using BooksEverywhere.Application.Features.Stacks.Queries.GetStacksList;
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
    public class StackController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StackController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all", Name = "GetAllStacks")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<StacksListVm>> GetAllStacks()
        {
            var dtos = await _mediator.Send(new GetStackListQuery());
            return Ok(dtos);
        }

        [HttpGet("id", Name ="GetStackById")]
        public async Task<ActionResult<Stack>> GetStackById(int id)
        {
            var getStackInfoQuery = new GetStackInfoQuery() { Id = id };
            return Ok(await _mediator.Send(getStackInfoQuery));
        }

        [HttpPost("AddStack")]
        public async Task<ActionResult<int>> CreateStack([FromBody] CreateStackCommand createStackCommand)
        {
            var response = await _mediator.Send(createStackCommand);
            return Ok(response);
        }

        [HttpPut("id", Name = "UpdateStack")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> UpdateStack([FromBody] UpdateStackCommand updateStackCommand)
        {
            await _mediator.Send(updateStackCommand);
            return NoContent();
        }

        [HttpDelete("id", Name = "DeleteStack")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> DeleteStack(int id)
        {
            var deleteStackCommand = new DeleteStackCommand() { Id = id };
            await _mediator.Send(deleteStackCommand);
            return NoContent();
        }
    }
}
