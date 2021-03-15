using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.Subjects.Commands.CreateSubject
{
    public class CreateSubjectValidator: AbstractValidator<CreateSubjectCommand>
    {
        public CreateSubjectValidator()
        {

        }
    }
}
