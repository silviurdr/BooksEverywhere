using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.BookLends.Commands.CreateBookLend
{
    public class CreateBookLendValidator: AbstractValidator<CreateBookLendCommand>
    {
        public CreateBookLendValidator()
        {
            RuleFor(p => p.BooksList)
                .NotEmpty();
        }
    }
}
