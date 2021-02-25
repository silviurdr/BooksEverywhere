using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.Subjects.Queries.GetSubjectsList
{
    public class GetSubjectsListQuery: IRequest<List<SubjectsListVm>>
    {
    }
}
