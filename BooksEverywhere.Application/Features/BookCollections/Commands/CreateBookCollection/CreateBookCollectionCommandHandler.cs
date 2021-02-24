using AutoMapper;
using BooksEverywhere.Application.Interfaces.Persistence;
using BooksEverywhere.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BooksEverywhere.Application.Features.BookCollections.Commands.CreateBookCollection
{
    class CreateBookCollectionCommandHandler : IRequestHandler<CreateBookCollectionCommand, int>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<BookCollection> _bookCollectionRepository;

        public CreateBookCollectionCommandHandler(IMapper mapper, IAsyncRepository<BookCollection> bookCollectionRepository)
        {
            _mapper = mapper;
            _bookCollectionRepository = bookCollectionRepository;
        }
        public async Task<int> Handle(CreateBookCollectionCommand request, CancellationToken cancellationToken)
        {

            var validation = new CreateBookCollectionCommandValidator();

            var validationResult = await validation.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
            {
                throw new GloboTicket.TicketManagement.Application.Exceptions.ValidationException(validationResult);
            }

            var @bookCollection = _mapper.Map<BookCollection>(request);
            @bookCollection = await _bookCollectionRepository.AddAsync(@bookCollection);

            return @bookCollection.Id;
        }
    }
}
