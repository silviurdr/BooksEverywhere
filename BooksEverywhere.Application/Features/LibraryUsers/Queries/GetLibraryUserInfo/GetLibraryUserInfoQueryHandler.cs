using AutoMapper;
using BooksEverywhere.Application.Interfaces.Persistence;
using BooksEverywhere.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BooksEverywhere.Application.Features.LibraryUsers.Queries.GetLibraryUserInfo
{
    public class GetLibraryUserInfoQueryHandler : IRequestHandler<GetLibraryUserInfoQuery, LibraryUserInfoVm>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<LibraryUser> _libraryUserRepository;

        public GetLibraryUserInfoQueryHandler(IMapper mapper, IAsyncRepository<LibraryUser> libraryUserRepository)
        {
            _mapper = mapper;
            _libraryUserRepository = libraryUserRepository;
        }
        public async Task<LibraryUserInfoVm> Handle(GetLibraryUserInfoQuery request, CancellationToken cancellationToken)
        {
            var @libraryUser = await _libraryUserRepository.GetByIdAsync(request.Id);
            var libraryUserDto = _mapper.Map<LibraryUserInfoVm>(@libraryUser);

            return libraryUserDto;
        }
    }
}
