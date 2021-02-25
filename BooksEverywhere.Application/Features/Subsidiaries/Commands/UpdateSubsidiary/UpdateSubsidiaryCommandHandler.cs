using AutoMapper;
using BooksEverywhere.Application.Interfaces.Persistence;
using BooksEverywhere.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BooksEverywhere.Application.Features.Subsidiaries.Commands.UpdateSubsidiary
{
    public class UpdateSubsidiaryCommandHandler : IRequestHandler<UpdateSubsidiaryCommand>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Subsidiary> _subsidiariesRepository;

        public UpdateSubsidiaryCommandHandler(IMapper mapper, IAsyncRepository<Subsidiary> subsidiariesRepository)
        {
            _mapper = mapper;
            _subsidiariesRepository = subsidiariesRepository;
        }
        public async Task<Unit> Handle(UpdateSubsidiaryCommand request, CancellationToken cancellationToken)
        {
            var subsidiaryToUpdate = await _subsidiariesRepository.GetByIdAsync(request.Id);
            _mapper.Map(request, subsidiaryToUpdate, typeof(UpdateSubsidiaryCommand), typeof(Subsidiary));

            return Unit.Value;
        }
    }
}
