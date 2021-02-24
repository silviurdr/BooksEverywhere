using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BooksEverywhere.Application.Features.Rooms.Commands.CreateRoom
{
    public class CreateRoomValidator: AbstractValidator<CreateRoomCommand>
    {
        public CreateRoomValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty();
        }
    }
}
