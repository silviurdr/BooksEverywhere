using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.LibraryUsers.Commands.CreateLibraryUser
{
    class CreateLibraryUserCommandValidator: AbstractValidator<CreateLibraryUserCommand>
    {
            public CreateLibraryUserCommandValidator()
            {
            RuleFor(p => p.Name)
               .MaximumLength(200);
            }
    }
}
