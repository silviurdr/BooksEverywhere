using AutoMapper;
using BooksEverywhere.Application.Interfaces.Persistence;
using BooksEverywhere.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BooksEverywhere.Application.Features.Subjects.Commands.CreateSubject
{
    public class CreateSubjectCommandHandler : IRequestHandler<CreateSubjectCommand, int>
    {
        private readonly IAsyncRepository<Subject> _subjectsRepository;
        private readonly IMapper _mapper;

        public CreateSubjectCommandHandler(IMapper mapper, IAsyncRepository<Subject> subjectsRepository)
        {
            _mapper = mapper;
            _subjectsRepository = subjectsRepository;
        }

        public IMapper Mapper { get; }

        public async Task<int> Handle(CreateSubjectCommand request, CancellationToken cancellationToken)
        {
            var validator = new CreateSubjectValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0)
            {
                throw new GloboTicket.TicketManagement.Application.Exceptions.ValidationException(validationResult);
            }

            var @subject = _mapper.Map<Subject>(request);
            await _subjectsRepository.AddAsync(@subject);

            return @subject.Id;
        }
    }
}
