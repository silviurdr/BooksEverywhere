using AutoMapper;
using BooksEverywhere.Application.Features.Authors.Commands.CreateAuthor;
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
        private readonly IAuthorRepository _authorRepository;

        public CreateBookCommandHandler(IMapper mapper, IAsyncRepository<Book> bookRepository, IAuthorRepository authorRepository)
        {
            _mapper = mapper;
            _bookRepository = bookRepository;
            _authorRepository = authorRepository;
        }

        public async Task<int> Handle(CreateBookCommand request, CancellationToken cancellationToken)
        {

            var validator = new CreateBookCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
            {
                throw new Exceptions.ValidationException(validationResult);
            }

            var author = await _authorRepository.GetAuthorByName(request.AuthorName);

            if(author == null)
            {
                await CreateNewAuthor(request);

                author = await _authorRepository.GetAuthorByName(request.AuthorName);
            }

            var @book = _mapper.Map<Book>(request);

            @book.AuthorId = author.Id;
            @book = await _bookRepository.AddAsync(@book);

            return @book.Id;
        }

        private async Task CreateNewAuthor(CreateBookCommand request)
        {
            var names = request.AuthorName.Split(' ');
            var firstName = names[0];
            var lastName = names[1];

            CreateAuthorCommand createAuthorCommand = new CreateAuthorCommand() { FirstName = firstName, LastName = lastName };

            await _authorRepository.AddAsync(_mapper.Map<Author>(createAuthorCommand));
        }
    }
}
