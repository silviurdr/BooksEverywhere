using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.Subsidiaries.Queries.GetSubsidiariesList
{
    public class GetSubsidiariesListQuery: IRequest<List<SubsidiariesListVm>>
    {
    }
}
