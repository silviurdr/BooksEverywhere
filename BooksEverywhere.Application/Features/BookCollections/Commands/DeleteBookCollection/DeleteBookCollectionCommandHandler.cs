using AutoMapper;
using BooksEverywhere.Application.Interfaces.Persistence;
using BooksEverywhere.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BooksEverywhere.Application.Features.BookCollections.Commands.DeleteBookCollection
{
    public class DeleteBookCollectionCommandHandler : IRequestHandler<DeleteBookCollectionCommand>
    {
        private readonly IAsyncRepository<BookCollection> _bookCollectionRepository;

        public DeleteBookCollectionCommandHandler(IAsyncRepository<BookCollection> bookCollectionRepository)
        {
            _bookCollectionRepository = bookCollectionRepository;
        }
        public async Task<Unit> Handle(DeleteBookCollectionCommand request, CancellationToken cancellationToken)
        {
            var bookCollectionToDelete = await _bookCollectionRepository.GetByIdAsync(request.Id);
            await _bookCollectionRepository.DeleteAsync(bookCollectionToDelete);

            return Unit.Value;
        }
    }
}
