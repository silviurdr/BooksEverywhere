using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.Subsidiaries.Queries.GetSubsidiaryInfo
{
    public class GetSubsidiaryInfoQuery : IRequest<SubsidiaryInfoVm>
    {
        public int Id { get; set; }
    }
}
