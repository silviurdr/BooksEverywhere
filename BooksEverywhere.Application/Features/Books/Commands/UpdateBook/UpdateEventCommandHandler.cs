using AutoMapper;
using BooksEverywhere.Application.Interfaces.Persistence;
using BooksEverywhere.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BooksEverywhere.Application.Features.Books.Commands.UpdateBook
{
    public class UpdateEventCommandHandler : IRequestHandler<UpdateBookCommand>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Book> _bookRepository;

        public UpdateEventCommandHandler(IMapper mapper, IAsyncRepository<Book> bookRepository)
        {
            _mapper = mapper;
            _bookRepository = bookRepository;
        }
        public async Task<Unit> Handle(UpdateBookCommand request, CancellationToken cancellationToken)
        {
            var bookToUpdate = await _bookRepository.GetByIdAsync(request.Id);

            _mapper.Map(request, bookToUpdate, typeof(UpdateBookCommand), typeof(Book));

            await _bookRepository.UpdateAsync(bookToUpdate);

            return Unit.Value;
        }
    }
}
