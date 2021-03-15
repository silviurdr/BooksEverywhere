using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.BookLends.Commands.UpdateBookLend
{
    public class UpdateBookLendCommandValidator: AbstractValidator<UpdateBookLendCommand>
    {
        public UpdateBookLendCommandValidator()
        {

        }
    }
}
