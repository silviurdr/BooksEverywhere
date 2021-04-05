using FluentValidation;

namespace BooksEverywhere.Application.Features.Authors.Commands.CreateAuthor
{
    public class CreateAuthorCommandValidator: AbstractValidator<CreateAuthorCommand>
    {
        public CreateAuthorCommandValidator()
        {
            RuleFor(p => p.FirstName)
                .NotEmpty().WithMessage("{PropertyName} is required.");

            RuleFor(p => p.LastName)
                .NotEmpty().WithMessage("{PropertyName} is required.");
        }
    }
}