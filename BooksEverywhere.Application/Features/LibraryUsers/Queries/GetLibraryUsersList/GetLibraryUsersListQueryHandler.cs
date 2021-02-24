using AutoMapper;
using BooksEverywhere.Application.Interfaces.Persistence;
using BooksEverywhere.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BooksEverywhere.Application.Features.LibraryUsers.Queries.GetLibraryUsersList
{
    public class GetLibraryUsersListQueryHandler : IRequestHandler<GetLibraryUsersListQuery, List<LibraryUsersListVm>>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<LibraryUser> _libraryUsersRepository;

        public GetLibraryUsersListQueryHandler(IMapper mapper, IAsyncRepository<LibraryUser> libraryUsersRepository)
        {
            _mapper = mapper;
            _libraryUsersRepository = libraryUsersRepository;
        }
        public async Task<List<LibraryUsersListVm>> Handle(GetLibraryUsersListQuery request, CancellationToken cancellationToken)
        {
            var allLibraryUsers = (await _libraryUsersRepository.ListAllAsync());

            return _mapper.Map<List<LibraryUsersListVm>>(allLibraryUsers);

        }
    }
}
