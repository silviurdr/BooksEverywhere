using BooksEverywhere.Application.Interfaces.Persistence;
using BooksEverywhere.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BooksEverywhere.Application.Features.Libraries.Commands.DeleteLibrary
{
    public class DeleteLibraryCommandHandler : IRequestHandler<DeleteLibraryCommand>
    {
        private readonly IAsyncRepository<Library> _libaryRepository;

        public DeleteLibraryCommandHandler(IAsyncRepository<Library> libaryRepository)
        {
            _libaryRepository = libaryRepository;
        }
        public async Task<Unit> Handle(DeleteLibraryCommand request, CancellationToken cancellationToken)
        {
            var bookToDelete = await _libaryRepository.GetByIdAsync(request.Id);

            await _libaryRepository.DeleteAsync(bookToDelete);

            return Unit.Value;
        }
    }
}
