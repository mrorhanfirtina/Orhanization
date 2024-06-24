using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Buildings.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Buildings.Validators;

public class DeleteBuildingValidator : AbstractValidator<DeleteBuildingCommand>
{
    public DeleteBuildingValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
