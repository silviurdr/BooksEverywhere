using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.Subjects.Commands.DeleteSubject
{
    public class DeleteSubjectCommand: IRequest
    {
        public int Id { get; set; }
    }
}
