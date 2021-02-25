using BooksEverywhere.Application.Interfaces.Persistence;
using BooksEverywhere.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BooksEverywhere.Application.Features.BookLends.Commands.DeleteBookLend
{
    public class DeleteBookLendCommandHandler : IRequestHandler<DeleteBookLendCommand>
    {
        private readonly IAsyncRepository<BookLend> _bookLendsRepository;

        public DeleteBookLendCommandHandler(IAsyncRepository<BookLend> bookLendsRepository)
        {
            _bookLendsRepository = bookLendsRepository;
        }
        public async Task<Unit> Handle(DeleteBookLendCommand request, CancellationToken cancellationToken)
        {
            var bookLendToDelete = await _bookLendsRepository.GetByIdAsync(request.Id);
            await _bookLendsRepository.DeleteAsync(bookLendToDelete);

            return Unit.Value;
        }
    }
}
