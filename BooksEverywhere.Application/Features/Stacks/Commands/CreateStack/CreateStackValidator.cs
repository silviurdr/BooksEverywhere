using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.Stacks.Commands.CreateStack
{
    public class CreateStackValidator: AbstractValidator<CreateStackCommand>
    {
        public CreateStackValidator()
        {
            RuleFor(p => p.Shelves)
                .NotEmpty();
        }
    }
}
