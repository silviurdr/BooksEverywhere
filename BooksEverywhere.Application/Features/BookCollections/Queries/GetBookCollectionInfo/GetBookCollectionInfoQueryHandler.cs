using AutoMapper;
using BooksEverywhere.Application.Features.BookCollections.Queries.GetBookCollectionsList;
using BooksEverywhere.Application.Interfaces.Persistence;
using BooksEverywhere.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BooksEverywhere.Application.Features.BookCollections.Queries.GetBookCollectionInfo
{
    public class GetBookCollectionInfoQueryHandler : IRequestHandler<GetBookCollectionInfoQuery, BookCollectionInfoVm>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<BookCollection> _bookCollectionRepository;

        public GetBookCollectionInfoQueryHandler(IMapper mapper, IAsyncRepository<BookCollection> bookCollectionRepository)
        {
            _mapper = mapper;
            _bookCollectionRepository = bookCollectionRepository;
        }
        public async Task<BookCollectionInfoVm> Handle(GetBookCollectionInfoQuery request, CancellationToken cancellationToken)
        {
            var @bookCollection = await _bookCollectionRepository.GetByIdAsync(request.Id);

            var bookCollectionInfoDto = _mapper.Map<BookCollectionInfoVm>(@bookCollection);

            return bookCollectionInfoDto;
        }
    }
}
