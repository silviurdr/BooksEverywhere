using BooksEverywhere.Application.Interfaces.Persistence;
using BooksEverywhere.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BooksEverywhere.Application.Features.Authors.Commands.DeleteAuthor
{
    public class DeleteAuthorCommandHandler: IRequestHandler<DeleteAuthorCommand>
    {
        private readonly IAsyncRepository<Author> _authorRepository;

        public DeleteAuthorCommandHandler(IAsyncRepository<Author> authorRepository)
        {
            _authorRepository = authorRepository;
        }

        public async Task<Unit> Handle(DeleteAuthorCommand request, CancellationToken cancellationToken)
        {
            var authorToDelete = await _authorRepository.GetByIdAsync(request.Id);

            await _authorRepository.DeleteAsync(authorToDelete);

            return Unit.Value;
        }
    }
}
