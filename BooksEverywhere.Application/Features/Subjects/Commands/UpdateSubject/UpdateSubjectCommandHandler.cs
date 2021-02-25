using AutoMapper;
using BooksEverywhere.Application.Interfaces.Persistence;
using BooksEverywhere.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BooksEverywhere.Application.Features.Subjects.Commands.UpdateSubject
{
    public class UpdateSubjectCommandHandler : IRequestHandler<UpdateSubjectCommand>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Subject> _subjectsRepository;

        public UpdateSubjectCommandHandler(IMapper mapper, IAsyncRepository<Subject> subjectsRepository)
        {
            _mapper = mapper;
            _subjectsRepository = subjectsRepository;
        }
        public async Task<Unit> Handle(UpdateSubjectCommand request, CancellationToken cancellationToken)
        {
            var subjectToUpdate = await _subjectsRepository.GetByIdAsync(request.Id);
            _mapper.Map(request, subjectToUpdate, typeof(UpdateSubjectCommand), typeof(Subject));

            await _subjectsRepository.UpdateAsync(subjectToUpdate);

            return Unit.Value;
        }
    }
}
