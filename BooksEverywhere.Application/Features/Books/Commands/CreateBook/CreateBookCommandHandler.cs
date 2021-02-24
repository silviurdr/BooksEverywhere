using AutoMapper;
using BooksEverywhere.Application.Features.Books.Commands.CreateBook;
using BooksEverywhere.Application.Interfaces.Persistence;
using BooksEverywhere.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BooksEverywhere.Application.Features.Books.Commands
{
    public class CreateBookCommandHandler : IRequestHandler<CreateBookCommand, int>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Book> _bookRepository;

        public CreateBookCommandHandler(IMapper mapper, IAsyncRepository<Book> bookRepository)
        {
            _mapper = mapper;
            _bookRepository = bookRepository;
        }

        public async Task<int> Handle(CreateBookCommand request, CancellationToken cancellationToken)
        {

            var validator = new CreateBookCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
            {
                throw new GloboTicket.TicketManagement.Application.Exceptions.ValidationException(validationResult);
            }

            var @book = _mapper.Map<Book>(request);
            @book = await _bookRepository.AddAsync(@book);

            return @book.Id;
        }
    }
}
