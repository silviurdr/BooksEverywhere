using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.Stacks.Queries.GetStacksList
{
    public class GetStackListQuery: IRequest<List<StacksListVm>>
    {
    }
}
