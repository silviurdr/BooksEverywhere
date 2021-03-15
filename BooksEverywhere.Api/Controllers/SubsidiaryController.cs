using BooksEverywhere.Application.Features.Subsidiaries.Commands;
using BooksEverywhere.Application.Features.Subsidiaries.Commands.CreateSubsidiary;
using BooksEverywhere.Application.Features.Subsidiaries.Commands.UpdateSubsidiary;
using BooksEverywhere.Application.Features.Subsidiaries.Queries.GetSubsidiariesList;
using BooksEverywhere.Application.Features.Subsidiaries.Queries.GetSubsidiaryInfo;
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
    public class SubsidiaryController : ControllerBase
    {
        private readonly IMediator _mediator;

        public SubsidiaryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all", Name = "GetAllSubsidiaries")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<SubsidiariesListVm>>> GetAllSubsidiaries()
        {
            var dtos = await _mediator.Send(new GetSubsidiariesListQuery());
            return Ok(dtos);
        }

        [HttpGet("id", Name = "GetSubsidiaryById")]
        public async Task<ActionResult<SubsidiaryInfoVm>> GetSubsidiaryById(int id)
        {
            var getSubsdiaryInfoQuery = new GetSubsidiaryInfoQuery() { Id = id };
            return await _mediator.Send(getSubsdiaryInfoQuery);
        }

        [HttpPost("AddSubsidiary")]
        public async Task<ActionResult<int>> AddSubsidiary([FromBody] CreateSubsidiaryCommand createSubsidiaryCommand)
        {
            var response = await _mediator.Send(createSubsidiaryCommand);
            return Ok(response);
        }

        [HttpPut("id")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> UpdateSubsidiary([FromBody] UpdateSubsidiaryCommand updateSubsidiaryCommand)
        {
            await _mediator.Send(updateSubsidiaryCommand);
            return NoContent();
        }

        [HttpDelete("id")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> DeleteSubsidiary(int id)
        {
            var deleteSubsidiaryCommand = new DeleteSubsidiaryCommand() { Id = id };
            await _mediator.Send(deleteSubsidiaryCommand);
            return NoContent();

        }
    }
}
