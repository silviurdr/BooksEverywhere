using AutoMapper;
using BooksEverywhere.Application.Interfaces.Persistence;
using BooksEverywhere.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BooksEverywhere.Application.Features.Authors.Queries.GetAuthorInfo
{
    public class GetAuthorInfoQueryHandler : IRequestHandler<GetAuthorInfoQuery, AuthorInfoVm>
    {
        private readonly IMapper _mapper;
        private readonly IAuthorRepository _authorRepository;

        public GetAuthorInfoQueryHandler(IMapper mapper, IAuthorRepository authorRepository)
        {
            _mapper = mapper;
            _authorRepository = authorRepository;
        }
        async Task<AuthorInfoVm> IRequestHandler<GetAuthorInfoQuery, AuthorInfoVm>.Handle(GetAuthorInfoQuery request, CancellationToken cancellationToken)
        {

            var @author = await _authorRepository.GetByIdAsync(request.Id);

            var authorInfoDto = _mapper.Map<AuthorInfoVm>(@author);

            return authorInfoDto;

        }
    }
}
