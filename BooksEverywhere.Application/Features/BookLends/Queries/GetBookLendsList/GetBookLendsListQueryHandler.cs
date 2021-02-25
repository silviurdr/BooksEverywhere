using AutoMapper;
using BooksEverywhere.Application.Interfaces.Persistence;
using BooksEverywhere.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BooksEverywhere.Application.Features.BookLends.Queries.GetBookLendsList
{
    public class GetBookLendsListQueryHandler : IRequestHandler<GetBookLendsListQuery, List<BookLendListVm>>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<BookLend> _bookLendsRepository;

        public GetBookLendsListQueryHandler(IMapper mapper, IAsyncRepository<BookLend> bookLendsRepository)
        {
            _mapper = mapper;
            _bookLendsRepository = bookLendsRepository;
        }
        public async Task<List<BookLendListVm>> Handle(GetBookLendsListQuery request, CancellationToken cancellationToken)
        {
            var allBookLends = await _bookLendsRepository.ListAllAsync();

            return _mapper.Map<List<BookLendListVm>>(allBookLends);
        }
    }
}
