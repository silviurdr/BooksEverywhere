using AutoMapper;
using BooksEverywhere.Application.Interfaces.Persistence;
using BooksEverywhere.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BooksEverywhere.Application.Features.Stacks.Queries.GetStacksList
{
    public class GetStackListQueryHandler : IRequestHandler<GetStackListQuery, List<StacksListVm>>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Stack> _stacksRepository;

        public GetStackListQueryHandler(IMapper mapper, IAsyncRepository<Stack> stacksRepository)
        {
            _mapper = mapper;
            _stacksRepository = stacksRepository;
        }
        public async Task<List<StacksListVm>> Handle(GetStackListQuery request, CancellationToken cancellationToken)
        {
            var allStacks = await _stacksRepository.ListAllAsync();

            return _mapper.Map<List<StacksListVm>>(allStacks);
        }
    }
}
