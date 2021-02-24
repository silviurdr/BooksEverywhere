using AutoMapper;
using BooksEverywhere.Application.Interfaces.Persistence;
using BooksEverywhere.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BooksEverywhere.Application.Features.Libraries.Commands.UpdateLibrary
{
    class UpdateLibraryCommandHandler : IRequestHandler<UpdateLibraryCommand>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Library> _libraryRepository;

        public UpdateLibraryCommandHandler(IMapper mapper, IAsyncRepository<Library> libraryRepository)
        {
            _mapper = mapper;
            _libraryRepository = libraryRepository;
        }
        public async Task<Unit> Handle(UpdateLibraryCommand request, CancellationToken cancellationToken)
        {
            var libaryToUpdate = await _libraryRepository.GetByIdAsync(request.Id);
            _mapper.Map(request, libaryToUpdate, typeof(UpdateLibraryCommand), typeof(Book));

            await _libraryRepository.UpdateAsync(libaryToUpdate);

            return Unit.Value;
        }
    }
}
