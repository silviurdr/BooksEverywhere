using BooksEverywhere.Application.Features.Subjects.Commands.CreateSubject;
using BooksEverywhere.Application.Features.Subjects.Commands.DeleteSubject;
using BooksEverywhere.Application.Features.Subjects.Commands.UpdateSubject;
using BooksEverywhere.Application.Features.Subjects.Queries.GetSubjectInfo;
using BooksEverywhere.Application.Features.Subjects.Queries.GetSubjectsList;
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
    public class SubjectController : ControllerBase
    {
        private readonly IMediator _mediator;

        public SubjectController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all", Name = "GetAllSubjects")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<SubjectsListVm>>> GetAllSubjects()
        {
            var dtos = await _mediator.Send(new GetSubjectsListQuery());
            return Ok(dtos);
        }

        [HttpGet("id", Name = "GetSubjectById")]
        public async Task<ActionResult<SubjectInfoVm>> GetSubjectById(int id)
        {
            var getSubjectInfoQuery = new GetSubjectInfoQuery() { Id = id };
            return Ok(await _mediator.Send(getSubjectInfoQuery));
        }

        [HttpPost("AddSubject")]
        public async Task<ActionResult<int>> CreateSubject([FromBody] CreateSubjectCommand createSubjectCommand)
        {
            var response = await _mediator.Send(createSubjectCommand);
            return Ok(response);
        }

        [HttpPut("id", Name = "UpdateSubject")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> UpdateSubject([FromBody] UpdateSubjectCommand updateSubjectCommand)
        {
            await _mediator.Send(updateSubjectCommand);
            return NoContent();
        }

        [HttpDelete("id", Name = "DeleteSubject")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> DeleteSubject(int id)
        {
            var deleteSubjectCommand = new DeleteSubjectCommand() { Id = id };
            await _mediator.Send(deleteSubjectCommand);
            return NoContent();
        }
    }
}
