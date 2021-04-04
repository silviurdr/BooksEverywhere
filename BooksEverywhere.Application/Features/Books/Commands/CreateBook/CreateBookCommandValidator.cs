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

            RuleFor(p => p.BookDetails.Title)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull();

            RuleFor(p => p.BookDetails.Description)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull();
        }
    }
}
