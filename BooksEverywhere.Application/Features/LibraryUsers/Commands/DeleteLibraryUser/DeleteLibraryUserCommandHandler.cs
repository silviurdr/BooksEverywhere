using BooksEverywhere.Application.Interfaces.Persistence;
using BooksEverywhere.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BooksEverywhere.Application.Features.LibraryUsers.Commands.DeleteLibraryUser
{
    public class DeleteLibraryUserCommandHandler : IRequestHandler<DeleteLibraryUserCommand>
    {
        private readonly IAsyncRepository<LibraryUser> _libraryUserRepository;

        public DeleteLibraryUserCommandHandler(IAsyncRepository<LibraryUser> libraryUserRepository)
        {
            _libraryUserRepository = libraryUserRepository;
        }
        public async Task<Unit> Handle(DeleteLibraryUserCommand request, CancellationToken cancellationToken)
        {
            var libraryUserToDelete = await _libraryUserRepository.GetByIdAsync(request.Id);
            await _libraryUserRepository.DeleteAsync(libraryUserToDelete);

            return Unit.Value;
        }
    }
}
