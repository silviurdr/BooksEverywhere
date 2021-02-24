﻿using AutoMapper;
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
    class DeleteEventCommandHandler : IRequestHandler<DeleteBookCommand>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Book> _bookRepository;

        public DeleteEventCommandHandler(IMapper mapper, IAsyncRepository<Book> bookRepository)
        {
            _mapper = mapper;
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
