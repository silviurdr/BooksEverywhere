using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.LibraryUsers.Commands.UpdateLibraryUser
{
    public class UpdateLibraryUserCommandValidator: AbstractValidator<UpdateLibraryUserCommand>
    {
        public UpdateLibraryUserCommandValidator()
        {

        }
    }
}
