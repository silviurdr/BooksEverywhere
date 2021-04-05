using AutoMapper;
using BooksEverywhere.Application.Exceptions;
using BooksEverywhere.Application.Features.Authors.Queries.GetAuthorByName;
using BooksEverywhere.Application.Interfaces.Persistence;
using BooksEverywhere.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BooksEverywhere.Application.Features.Authors.Queries.GetAuthorIdByAuthorName
{
    public class GetAuthorByNameQueryHandler: IRequestHandler<GetAuthorByNameQuery, AuthorByNameVm>
    {
        private readonly IMapper _mapper;
        private readonly IAuthorRepository _authorRepository;

        public GetAuthorByNameQueryHandler(IMapper mapper, IAuthorRepository authorRepository)
        {
            _mapper = mapper;
            _authorRepository = authorRepository;
        }
        public async Task<AuthorByNameVm> Handle(GetAuthorByNameQuery request, CancellationToken cancellationToken)
        {
            var @author = await _authorRepository.GetAuthorByName(request.FullName);

            if (@author == null)
            {
                throw new NotFoundException(nameof(Author), request.FullName);
            }

            var authorDto = _mapper.Map<AuthorByNameVm>(@author);
            authorDto.AuthorName = request.FullName;

            return authorDto;
        }
    }
}
