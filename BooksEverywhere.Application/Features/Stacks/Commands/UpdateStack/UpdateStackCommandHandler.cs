using AutoMapper;
using BooksEverywhere.Application.Interfaces.Persistence;
using BooksEverywhere.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BooksEverywhere.Application.Features.Stacks.Commands.UpdateStack
{
    public class UpdateStackCommandHandler : IRequestHandler<UpdateStackCommand>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Stack> _stacksRepository;

        public UpdateStackCommandHandler(IMapper mapper, IAsyncRepository<Stack> stacksRepository)
        {
            _mapper = mapper;
            _stacksRepository = stacksRepository;
        }
        public async Task<Unit> Handle(UpdateStackCommand request, CancellationToken cancellationToken)
        {
            var stackToUpdate = await _stacksRepository.GetByIdAsync(request.Id);
            _mapper.Map(request, stackToUpdate, typeof(UpdateStackCommand), typeof(Stack));

            await _stacksRepository.UpdateAsync(stackToUpdate);

            return Unit.Value;
        }
    }
}
