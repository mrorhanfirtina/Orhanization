using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Zones.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Zones.Validators;

public class DeleteZoneValidator : AbstractValidator<DeleteZoneCommand>
{
    public DeleteZoneValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
