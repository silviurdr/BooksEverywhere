using AutoMapper;
using BooksEverywhere.Application.Interfaces.Persistence;
using BooksEverywhere.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace BooksEverywhere.Application.Features.Libraries.Queries.GetLibraryInfo
{
    class GetLibraryInfoQueryHandler : IRequestHandler<GetLibraryInfoQuery, LibraryInfoVm>
    {
        private readonly IMapper _mapper;
        private readonly ILibraryRepository _libraryRepository;

        public GetLibraryInfoQueryHandler(IMapper mapper, ILibraryRepository libraryRepository)
        {
            _mapper = mapper;
            _libraryRepository = libraryRepository;
        }
        public async Task<LibraryInfoVm> Handle(GetLibraryInfoQuery request, CancellationToken cancellationToken)
        {
            var @library = await _libraryRepository.GetByIdAsync(request.Id);
            var libraryInfoDto = _mapper.Map<LibraryInfoVm>(@library);

            return libraryInfoDto;
        }
    }
}
