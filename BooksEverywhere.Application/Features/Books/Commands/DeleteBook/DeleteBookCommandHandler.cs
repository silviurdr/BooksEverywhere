using AutoMapper;
using BooksEverywhere.Application.Interfaces.Persistence;
using BooksEverywhere.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BooksEverywhere.Application.Features.Books.Commands.DeleteBook
{
    class DeleteBookCommandHandler : IRequestHandler<DeleteBookCommand>
    {

        private readonly IAsyncRepository<Book> _bookRepository;

        public DeleteBookCommandHandler(IAsyncRepository<Book> bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public async Task<Unit> Handle(DeleteBookCommand request, CancellationToken cancellationToken)
        {
            var bookToDelete = await _bookRepository.GetByIdAsync(request.Id);

            await _bookRepository.DeleteAsync(bookToDelete);

            return Unit.Value;
        }
    }
}
