using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.Libraries.Commands.UpdateLibrary
{
    public class UpdateLibraryCommandValidator: AbstractValidator<UpdateLibraryCommand>
    {
        public UpdateLibraryCommandValidator()
        {

        }
    }
}
