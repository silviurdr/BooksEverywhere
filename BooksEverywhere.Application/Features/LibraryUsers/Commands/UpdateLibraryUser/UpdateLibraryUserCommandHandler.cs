using AutoMapper;
using BooksEverywhere.Application.Interfaces.Persistence;
using BooksEverywhere.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BooksEverywhere.Application.Features.LibraryUsers.Commands.UpdateLibraryUser
{
    public class UpdateLibraryUserCommandHandler : IRequestHandler<UpdateLibraryUserCommand>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<LibraryUser> _libraryUserRepository;

        public UpdateLibraryUserCommandHandler(IMapper mapper, IAsyncRepository<LibraryUser> libraryUserRepository)
        {
            _mapper = mapper;
            _libraryUserRepository = libraryUserRepository;
        }
        public async Task<Unit> Handle(UpdateLibraryUserCommand request, CancellationToken cancellationToken)
        {
            var libraryUserToUpdate = await _libraryUserRepository.GetByIdAsync(request.Id);

            _mapper.Map(request, libraryUserToUpdate, typeof(UpdateLibraryUserCommand), typeof(LibraryUser));

            await _libraryUserRepository.UpdateAsync(libraryUserToUpdate);

            return Unit.Value;
        }
    }
}
