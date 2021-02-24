using AutoMapper;
using BooksEverywhere.Application.Interfaces.Persistence;
using BooksEverywhere.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BooksEverywhere.Application.Features.BookCollections.Queries.GetBookCollectionList
{
    class GetBookCollectionListQueryHandler : IRequestHandler<GetBookCollectionListQuery, List<BookCollectionListVm>>
    {
        private readonly IMapper _mapper;
        private readonly Interfaces.Persistence.IAsyncRepository<BookCollection> _bookCollectionRepository;

        public GetBookCollectionListQueryHandler(IMapper mapper, IAsyncRepository<BookCollection> bookCollectionRepository)
        {
            _mapper = mapper;
            _bookCollectionRepository = bookCollectionRepository;
        }
        public async Task<List<BookCollectionListVm>> Handle(GetBookCollectionListQuery request, CancellationToken cancellationToken)
        {
            var allBookCollections = await _bookCollectionRepository.ListAllAsync();

            return _mapper.Map<List<BookCollectionListVm>>(allBookCollections);
        }
    }
}
