using AutoMapper;
using BooksEverywhere.Application.Features.Events;
using BooksEverywhere.Application.Interfaces.Persistence;
using BooksEverywhere.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BooksEverywhere.Application.Features.Books.Queries.GetBookDetail
{
    public class GetBookInfoQueryHandler : IRequestHandler<GetBookInfoQuery, BookInfoVm>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Book> _bookRepository;

        public GetBookInfoQueryHandler(IMapper mapper, IAsyncRepository<Book> bookRepository)
        {
            _mapper = mapper;
            _bookRepository = bookRepository;
        }
        public async Task<BookInfoVm> Handle(GetBookInfoQuery request, CancellationToken cancellationToken)
        {
            var @book = await _bookRepository.GetByIdAsync(request.Id);
            var bookInfoDto = _mapper.Map<BookInfoVm>(@book);

            return bookInfoDto;

        }
    }
}
