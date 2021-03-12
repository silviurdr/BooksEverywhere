using AutoMapper;
using BooksEverywhere.Application.Interfaces.Persistence;
using BooksEverywhere.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace BooksEverywhere.Application.Features.Events
{
    public class GeBooksListQueryHandler : IRequestHandler<GetBooksListQuery, List<BookListVm>>
    {
        private readonly IMapper _mapper;
        private readonly IBookRepository _bookRepository;

        public GeBooksListQueryHandler(IMapper mapper, IBookRepository bookRepository)
        {
            _mapper = mapper;
            _bookRepository = bookRepository;
        }
        public async Task<List<BookListVm>> Handle(GetBooksListQuery request, CancellationToken cancellationToken)
        {
            var allBooks = (await _bookRepository.ListAllAsync());

            return _mapper.Map<List<BookListVm>>(allBooks);
        }
    }
}


/*[HttpGet("all", Name = "GetAllBooks")]
public async Task<ActionResult<List<BookListVm>>> GetAllBooks()
{
    var dtos = await _mediator.Send(new GetBooksListQuery());
    return Ok(dtos);
}
*/