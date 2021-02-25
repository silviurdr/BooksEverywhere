using AutoMapper;
using BooksEverywhere.Application.Interfaces.Persistence;
using BooksEverywhere.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BooksEverywhere.Application.Features.Subjects.Queries.GetSubjectInfo
{
    public class GetSubjectInfoQueryHandler : IRequestHandler<GetSubjectInfoQuery, SubjectInfoVm>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Subject> _subjectsRepository;

        public GetSubjectInfoQueryHandler(IMapper mapper, IAsyncRepository<Subject> subjectsRepository)
        {
            _mapper = mapper;
            _subjectsRepository = subjectsRepository;
        }
        public async Task<SubjectInfoVm> Handle(GetSubjectInfoQuery request, CancellationToken cancellationToken)
        {
            var @subject = await _subjectsRepository.GetByIdAsync(request.Id);
            var subjectDto = _mapper.Map<SubjectInfoVm>(@subject);

            return subjectDto;
        }
    }
}
