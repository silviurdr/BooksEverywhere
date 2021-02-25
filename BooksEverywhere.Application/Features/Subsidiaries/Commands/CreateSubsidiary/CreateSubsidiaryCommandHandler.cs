using AutoMapper;
using BooksEverywhere.Application.Interfaces.Persistence;
using BooksEverywhere.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace BooksEverywhere.Application.Features.Subsidiaries.Commands.CreateSubsidiary
{
    public class CreateSubsidiaryCommandHandler : IRequestHandler<CreateSubsidiaryCommand, int>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Subsidiary> _subsidiariesRepository;

        public CreateSubsidiaryCommandHandler(IMapper mapper, IAsyncRepository<Subsidiary> subsidiariesRepository)
        {
            _mapper = mapper;
            _subsidiariesRepository = subsidiariesRepository;
        }
        public async Task<int> Handle(CreateSubsidiaryCommand request, CancellationToken cancellationToken)
        {

            var validator = new CreateSubsidiaryValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
            {
                throw new Exceptions.ValidationException(validationResult);
            }

            var @subsidiary = _mapper.Map<Subsidiary>(request);
            await _subsidiariesRepository.AddAsync(@subsidiary);

            return @subsidiary.Id;
        }
    }
}
