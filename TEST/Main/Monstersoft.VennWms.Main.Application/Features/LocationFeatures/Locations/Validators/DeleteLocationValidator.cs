using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.Locations.Validators;

public class DeleteLocationValidator : AbstractValidator<DeleteLocationCommand>
{
    public DeleteLocationValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
