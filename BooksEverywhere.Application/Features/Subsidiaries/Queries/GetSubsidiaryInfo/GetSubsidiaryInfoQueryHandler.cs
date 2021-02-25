using AutoMapper;
using BooksEverywhere.Application.Interfaces.Persistence;
using BooksEverywhere.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BooksEverywhere.Application.Features.Subsidiaries.Queries.GetSubsidiaryInfo
{
    public class GetSubsidiaryInfoQueryHandler : IRequestHandler<GetSubsidiaryInfoQuery, SubsidiaryInfoVm>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Subsidiary> _subsidiariesRepository;

        public GetSubsidiaryInfoQueryHandler(IMapper mapper, IAsyncRepository<Subsidiary> subsidiariesRepository)
        {
            _mapper = mapper;
            _subsidiariesRepository = subsidiariesRepository;
        }
        public async Task<SubsidiaryInfoVm> Handle(GetSubsidiaryInfoQuery request, CancellationToken cancellationToken)
        {
            var @subsidiary = await _subsidiariesRepository.GetByIdAsync(request.Id);

            var subsidiaryInfoDto =  _mapper.Map<SubsidiaryInfoVm>(@subsidiary);

            return subsidiaryInfoDto;
        }
    }
}
