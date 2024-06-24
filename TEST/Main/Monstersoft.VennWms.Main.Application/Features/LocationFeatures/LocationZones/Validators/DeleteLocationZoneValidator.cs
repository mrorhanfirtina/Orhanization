using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationZones.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationZones.Validators;

public class DeleteLocationZoneValidator : AbstractValidator<DeleteLocationZoneCommand>
{
    public DeleteLocationZoneValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
