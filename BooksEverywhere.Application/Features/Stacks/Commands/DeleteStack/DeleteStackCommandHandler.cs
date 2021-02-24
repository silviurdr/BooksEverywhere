using BooksEverywhere.Application.Interfaces.Persistence;
using BooksEverywhere.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BooksEverywhere.Application.Features.Stacks.Commands.DeleteStack
{
    public class DeleteStackCommandHandler : IRequestHandler<DeleteStackCommand>
    {
        private readonly IAsyncRepository<Stack> _stacksRepository;

        public DeleteStackCommandHandler(IAsyncRepository<Stack> stacksRepository)
        {
            _stacksRepository = stacksRepository;
        }
        public async Task<Unit> Handle(DeleteStackCommand request, CancellationToken cancellationToken)
        {
            var stackToDelete = await _stacksRepository.GetByIdAsync(request.Id);
            await _stacksRepository.DeleteAsync(stackToDelete);

            return Unit.Value;
        }
    }
}
