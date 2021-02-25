using AutoMapper;
using BooksEverywhere.Application.Interfaces.Persistence;
using BooksEverywhere.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BooksEverywhere.Application.Features.Subsidiaries.Queries.GetSubsidiariesList
{
    public class GetSubsidiariesListQueryHandler : IRequestHandler<GetSubsidiariesListQuery, List<SubsidiariesListVm>>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Subsidiary> _subsidiariesRepository;

        public GetSubsidiariesListQueryHandler(IMapper mapper, IAsyncRepository<Subsidiary> subsidiariesRepository)
        {
            _mapper = mapper;
            _subsidiariesRepository = subsidiariesRepository;
        }
        public async Task<List<SubsidiariesListVm>> Handle(GetSubsidiariesListQuery request, CancellationToken cancellationToken)
        {
            var subsidiariesList = await _subsidiariesRepository.ListAllAsync();

            return _mapper.Map<List<SubsidiariesListVm>>(subsidiariesList);
        }
    }
}
