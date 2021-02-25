using AutoMapper;
using BooksEverywhere.Application.Interfaces.Persistence;
using BooksEverywhere.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BooksEverywhere.Application.Features.BookLends.Commands.CreateBookLend
{
    public class CreateBookLendCommandHandler : IRequestHandler<CreateBookLendCommand, int>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<BookLend> _bookLendsRepository;

        public CreateBookLendCommandHandler(IMapper mapper, IAsyncRepository<BookLend> bookLendsRepository)
        {
            _mapper = mapper;
            _bookLendsRepository = bookLendsRepository;
        }
        public async Task<int> Handle(CreateBookLendCommand request, CancellationToken cancellationToken)
        {

            var validator = new CreateBookLendValidator();
            var validationResult = await validator.ValidateAsync(request);

            if(validationResult.Errors.Count > 0)
            {
                throw new Exceptions.ValidationException(validationResult);
            }

            var @bookLend = _mapper.Map<BookLend>(request);
            @bookLend = await _bookLendsRepository.AddAsync(@bookLend);

            return bookLend.Id;
        }
    }
}
