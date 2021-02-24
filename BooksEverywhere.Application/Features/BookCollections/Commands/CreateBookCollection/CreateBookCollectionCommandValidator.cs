using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.BookCollections.Commands.CreateBookCollection
{
    class CreateBookCollectionCommandValidator : AbstractValidator<CreateBookCollectionCommand>
    {
        public CreateBookCollectionCommandValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty();
        }
    }
}
