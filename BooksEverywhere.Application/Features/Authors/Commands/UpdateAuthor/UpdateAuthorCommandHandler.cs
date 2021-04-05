using AutoMapper;
using BooksEverywhere.Application.Interfaces.Persistence;
using BooksEverywhere.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BooksEverywhere.Application.Features.Authors.Commands.UpdateAuthor
{
    public class UpdateAuthorCommandHandler: IRequestHandler<UpdateAuthorCommand>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Author> _authorRepository;

        public UpdateAuthorCommandHandler(IMapper mapper, IAsyncRepository<Author> authorRepository)
        {
            _mapper = mapper;
            _authorRepository = authorRepository;
        }

        public async Task<Unit> Handle(UpdateAuthorCommand request, CancellationToken cancellationToken)
        {
            var authorToUpdate = await _authorRepository.GetByIdAsync(request.Id);
            _mapper.Map(request, authorToUpdate, typeof(UpdateAuthorCommand), typeof(Author));

            await _authorRepository.UpdateAsync(authorToUpdate);

            return Unit.Value;

        }
    }
}
