using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.Stacks.Queries.GetStackInfo
{
    public class GetStackInfoQuery: IRequest<StackInfoVm>
    {
        public int Id { get; set; }
    }
}
