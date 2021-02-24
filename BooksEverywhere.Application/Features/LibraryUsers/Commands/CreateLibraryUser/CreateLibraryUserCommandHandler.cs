using AutoMapper;
using BooksEverywhere.Application.Interfaces.Persistence;
using BooksEverywhere.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BooksEverywhere.Application.Features.LibraryUsers.Commands.CreateLibraryUser
{
    public class CreateLibraryUserCommandHandler : IRequestHandler<CreateLibraryUserCommand, int>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<LibraryUser> _libraryUserRepository;

        public CreateLibraryUserCommandHandler(IMapper mapper, IAsyncRepository<LibraryUser> libraryUserRepository)
        {
            _mapper = mapper;
            _libraryUserRepository = libraryUserRepository;
        }
        public async Task<int> Handle(CreateLibraryUserCommand request, CancellationToken cancellationToken)
        {
            var @libraryUser = _mapper.Map<LibraryUser>(request);
            @libraryUser = await _libraryUserRepository.AddAsync(@libraryUser);

            return @libraryUser.Id;
        }
    }
}
