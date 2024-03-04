using FluentValidation;

namespace Application.Features.Cars.Commands.Update
{
    public class UpdateCarCommandValidator : AbstractValidator<UpdateCarCommand>
    {
        public UpdateCarCommandValidator()
        {
            RuleFor(c => c.Model).NotEmpty().MaximumLength(100);
        }
    }
}
