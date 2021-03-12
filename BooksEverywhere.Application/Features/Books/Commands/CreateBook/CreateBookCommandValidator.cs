using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.Books.Commands.CreateBook
{
    public class CreateBookCommandValidator: AbstractValidator<CreateBookCommand>
    {
        public CreateBookCommandValidator()
        {
            RuleFor(p => p.BookDetails)
                .NotEmpty();

            RuleFor(p => p.BookDetails.Author)
                .NotEmpty().WithMessage("{PropertyName} is required.");

        }
    }
}
