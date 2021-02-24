using AutoMapper;
using BooksEverywhere.Application.Interfaces.Persistence;
using BooksEverywhere.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BooksEverywhere.Application.Features.Libraries.Commands.CreateLibrary
{
    public class CreateLibraryCommandHandler : IRequestHandler<CreateLibraryCommand, int>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Library> _libraryRepository;

        public CreateLibraryCommandHandler(IMapper mapper, IAsyncRepository<Library> libraryRepository)
        {
            _mapper = mapper;
            _libraryRepository = libraryRepository;
        }
        public async Task<int> Handle(CreateLibraryCommand request, CancellationToken cancellationToken)
        {

            var validator = new CreateLibraryCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
            {
                throw new GloboTicket.TicketManagement.Application.Exceptions.ValidationException(validationResult);
            }


            var @library = _mapper.Map<Library>(request);
            @library = await _libraryRepository.AddAsync(@library);

            return @library.Id;
        }
    }
}
