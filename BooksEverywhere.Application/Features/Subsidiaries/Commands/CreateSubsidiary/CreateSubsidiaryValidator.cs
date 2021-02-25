using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.Subsidiaries.Commands.CreateSubsidiary
{
    public class CreateSubsidiaryValidator: AbstractValidator<CreateSubsidiaryCommand>
    {
        public CreateSubsidiaryValidator()
        {
            RuleFor(p => p.LibraryInfo)
                .NotEmpty();
        }
    }
}
