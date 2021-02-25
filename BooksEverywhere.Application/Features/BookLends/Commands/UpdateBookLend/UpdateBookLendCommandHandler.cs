using AutoMapper;
using BooksEverywhere.Application.Interfaces.Persistence;
using BooksEverywhere.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BooksEverywhere.Application.Features.BookLends.Commands.UpdateBookLend
{
    public class UpdateBookLendCommandHandler : IRequestHandler<UpdateBookLendCommand>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<BookLend> _bookLendsRepository;

        public UpdateBookLendCommandHandler(IMapper mapper, IAsyncRepository<BookLend> bookLendsRepository)
        {
            _mapper = mapper;
            _bookLendsRepository = bookLendsRepository;
        }
        public async Task<Unit> Handle(UpdateBookLendCommand request, CancellationToken cancellationToken)
        {
            var bookLendToUpdate = await _bookLendsRepository.GetByIdAsync(request.Id);
            _mapper.Map(request, bookLendToUpdate, typeof(UpdateBookLendCommand), typeof(BookLend));

            await _bookLendsRepository.UpdateAsync(bookLendToUpdate);

            return Unit.Value;
        }
    }
}
