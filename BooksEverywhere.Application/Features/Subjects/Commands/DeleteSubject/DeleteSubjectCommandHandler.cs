
using BooksEverywhere.Application.Interfaces.Persistence;
using BooksEverywhere.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BooksEverywhere.Application.Features.Subjects.Commands.DeleteSubject
{
    public class DeleteSubjectCommandHandler : IRequestHandler<DeleteSubjectCommand>
    {
        private readonly IAsyncRepository<Subject> _subjectsRepository;

        public DeleteSubjectCommandHandler(IAsyncRepository<Subject> subjectsRepository)
        {
            _subjectsRepository = subjectsRepository;
        }
        public async Task<Unit> Handle(DeleteSubjectCommand request, CancellationToken cancellationToken)
        {
            var subjectToDelete = await _subjectsRepository.GetByIdAsync(request.Id);
            await _subjectsRepository.DeleteAsync(subjectToDelete);

            return Unit.Value;
        }
    }
}
