using AutoMapper;
using BooksEverywhere.Application.Interfaces.Persistence;
using BooksEverywhere.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BooksEverywhere.Application.Features.Stacks.Commands.CreateStack
{
    public class CreateStackCommandHandler : IRequestHandler<CreateStackCommand, int>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Stack> _stacksRepository;

        public CreateStackCommandHandler(IMapper mapper, IAsyncRepository<Stack> stacksRepository)
        {
            _mapper = mapper;
            _stacksRepository = stacksRepository;
        }
        public async Task<int> Handle(CreateStackCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateStackValidator();
            var validationResult = await validator.ValidateAsync(request);

            if(validationResult.Errors.Count > 0)
            {
                throw new Exceptions.ValidationException(validationResult);
            }

            var @stack = _mapper.Map<Stack>(request);
            await _stacksRepository.AddAsync(@stack);

            return @stack.Id;
        }
    }
}
