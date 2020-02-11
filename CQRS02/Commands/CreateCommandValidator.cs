using FluentValidation;

namespace CQRS02.Commands
{
    public class CreateCommandValidator : AbstractValidator<CreateCommand>
    {
        public CreateCommandValidator()
        {
            RuleFor(todoList => todoList.Description)
                .NotEmpty()
                .WithMessage("description is Required");
        }
    }
}