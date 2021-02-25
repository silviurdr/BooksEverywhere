using AutoMapper;
using BooksEverywhere.Application.Interfaces.Persistence;
using BooksEverywhere.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BooksEverywhere.Application.Features.BookLends.Queries.GetBookLendInfo
{
    public class GetBookLendInfoQueryHandler : IRequestHandler<GetBookLendInfoQuery, BookLendInfoVm>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<BookLend> _bookLendsRepository;

        public GetBookLendInfoQueryHandler(IMapper mapper, IAsyncRepository<BookLend> bookLendsRepository)
        {
            _mapper = mapper;
            _bookLendsRepository = bookLendsRepository;
        }
        public async Task<BookLendInfoVm> Handle(GetBookLendInfoQuery request, CancellationToken cancellationToken)
        {
            var @bookLend = await _bookLendsRepository.GetByIdAsync(request.Id);
            var bookLendDto = _mapper.Map<BookLendInfoVm>(@bookLend);

            return bookLendDto;
        }
    }
}
