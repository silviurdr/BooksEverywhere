using AutoMapper;
using BooksEverywhere.Application.Interfaces.Persistence;
using BooksEverywhere.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BooksEverywhere.Application.Features.Authors.Queries.GetAuthorsList
{
    public class GetAuthorListQueryHandler : IRequestHandler<GetAuthorListQuery, List<AuthorListVm>>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Author> _authorRepository;

        public GetAuthorListQueryHandler(IMapper mapper, IAsyncRepository<Author> authorRepository)
        {
            _mapper = mapper;
            _authorRepository = authorRepository;
        }
        public async Task<List<AuthorListVm>> Handle(GetAuthorListQuery request, CancellationToken cancellationToken)
        {
            var allAuthors = (await _authorRepository.ListAllAsync());

            return _mapper.Map<List<AuthorListVm>>(allAuthors);
        }
    }
}
