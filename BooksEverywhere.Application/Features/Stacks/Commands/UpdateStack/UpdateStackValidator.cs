using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.Stacks.Commands.UpdateStack
{
    public class UpdateStackValidator: AbstractValidator<UpdateStackCommand>
    {
        public UpdateStackValidator()
        {

        }
    }
}
