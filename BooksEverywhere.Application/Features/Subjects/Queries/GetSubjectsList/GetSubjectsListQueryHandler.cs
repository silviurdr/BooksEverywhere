using AutoMapper;
using BooksEverywhere.Application.Interfaces.Persistence;
using BooksEverywhere.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BooksEverywhere.Application.Features.Subjects.Queries.GetSubjectsList
{
    public class GetSubjectsListQueryHandler : IRequestHandler<GetSubjectsListQuery, List<SubjectsListVm>>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Subject> _subjectsRepository;

        public GetSubjectsListQueryHandler(IMapper mapper, IAsyncRepository<Subject> subjectsRepository)
        {
            _mapper = mapper;
            _subjectsRepository = subjectsRepository;
        }
        public async Task<List<SubjectsListVm>> Handle(GetSubjectsListQuery request, CancellationToken cancellationToken)
        {
            var allSubjects = await _subjectsRepository.ListAllAsync();

            return _mapper.Map<List<SubjectsListVm>>(allSubjects);
        }
    }
}
