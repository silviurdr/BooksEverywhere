using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.Libraries.Commands.CreateLibrary
{
    public class CreateLibraryCommandValidator: AbstractValidator<CreateLibraryCommand>
    {
        public CreateLibraryCommandValidator()
        {
            RuleFor(p => p.libraryInfo)
                .NotEmpty();
        }
    }
}
