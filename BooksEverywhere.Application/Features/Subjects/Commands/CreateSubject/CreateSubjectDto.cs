using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.Subjects.Commands.CreateSubject
{
    public class CreateSubjectDto
    {
        public int SubjectId { get; set; }
        public string Name { get; set; }
    }
}
