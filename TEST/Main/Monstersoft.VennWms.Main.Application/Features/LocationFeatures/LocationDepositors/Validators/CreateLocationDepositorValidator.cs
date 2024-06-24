using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationDepositors.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationDepositors.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationDepositors.Validators;

public class CreateLocationDepositorValidator : AbstractValidator<CreateLocationDepositorCommand>
{
    public CreateLocationDepositorValidator()
    {
        RuleFor(x => x.LocationDepositor).SetValidator(new CreateLocationDepositorDtoValidator());
    }
}

