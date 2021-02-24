using AutoMapper;
using BooksEverywhere.Application.Interfaces.Persistence;
using BooksEverywhere.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BooksEverywhere.Application.Features.BookCollections.Commands.UpdateBookCollection
{
    class UpdateBookCollectionCommandHandler : IRequestHandler<UpdateBookCollectionCommand>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<BookCollection> _bookCollectionRepository;

        public UpdateBookCollectionCommandHandler(IMapper mapper, IAsyncRepository<BookCollection> bookCollectionRepository)
        {
            _mapper = mapper;
            _bookCollectionRepository = bookCollectionRepository;
        }
        public async Task<Unit> Handle(UpdateBookCollectionCommand request, CancellationToken cancellationToken)
        {
            var bookCollectionToUpdate = await _bookCollectionRepository.GetByIdAsync(request.Id);

            _mapper.Map(request, bookCollectionToUpdate, typeof(UpdateBookCollectionCommand), typeof(BookCollection));

            await _bookCollectionRepository.UpdateAsync(bookCollectionToUpdate);

            return Unit.Value;
        }
    }
}
