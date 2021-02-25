using BooksEverywhere.Application.Interfaces.Persistence;
using BooksEverywhere.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BooksEverywhere.Application.Features.Subsidiaries.Commands.DeleteSubsidiary
{
    public class DeleteSubsidiaryCommandHandler : IRequestHandler<DeleteSubsidiaryCommand>
    {
        private readonly IAsyncRepository<Subsidiary> _subsidiariesRepository;

        public DeleteSubsidiaryCommandHandler(IAsyncRepository<Subsidiary> subsidiariesRepository)
        {
            _subsidiariesRepository = subsidiariesRepository;
        }
        public async Task<Unit> Handle(DeleteSubsidiaryCommand request, CancellationToken cancellationToken)
        {
            var subsidiaryToDelete = await _subsidiariesRepository.GetByIdAsync(request.Id);
            await _subsidiariesRepository.DeleteAsync(subsidiaryToDelete);

            return Unit.Value;
        }
    }
}
