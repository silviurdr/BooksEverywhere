using AutoMapper;
using BooksEverywhere.Application.Interfaces.Persistence;
using BooksEverywhere.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BooksEverywhere.Application.Features.Stacks.Queries.GetStackInfo
{
    public class GetStackInfoQueryHandler : IRequestHandler<GetStackInfoQuery, StackInfoVm>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Stack> _stacksRepository;

        public GetStackInfoQueryHandler(IMapper mapper, IAsyncRepository<Stack> stacksRepository)
        {
            _mapper = mapper;
            _stacksRepository = stacksRepository;
        }
        public async Task<StackInfoVm> Handle(GetStackInfoQuery request, CancellationToken cancellationToken)
        {
            var @stack = await _stacksRepository.GetByIdAsync(request.Id);
            var stackDto = _mapper.Map<StackInfoVm>(@stack);

            return stackDto;
        }
    }
}
