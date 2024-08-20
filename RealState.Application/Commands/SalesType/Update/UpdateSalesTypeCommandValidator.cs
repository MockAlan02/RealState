using FluentValidation;

namespace RealState.Application.Commands.SalesType.Update
{
    public class UpdateSalesTypeCommandValidator
    : AbstractValidator<UpdateSalesTypeCommand>
    {
        public UpdateSalesTypeCommandValidator()
        {
            RuleFor(x => x.Name)
            .Cascade(CascadeMode.Stop)
            .NotEmpty()
            .WithMessage("The Name field is required.")
            .Must(s => s.Length <= 50)
            .WithMessage("Name length cannot overpass 50 characters.");
            RuleFor(x => x.Description)
            .Cascade(CascadeMode.Stop)
            .NotEmpty()
            .WithMessage("The Description field is required.")
            .Must(s => s.Length <= 100)
            .WithMessage("Description length cannot overpass 100 characters.");
        }
    }
}