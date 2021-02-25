using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.Subjects.Queries.GetSubjectInfo
{
    public class GetSubjectInfoQuery: IRequest<SubjectInfoVm>
    {
        public int Id { get; set; }
    }
}
