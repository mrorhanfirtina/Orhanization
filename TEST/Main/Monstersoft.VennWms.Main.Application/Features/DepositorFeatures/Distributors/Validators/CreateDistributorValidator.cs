using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Distributors.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Distributors.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Distributors.Validators;

public class CreateDistributorValidator : AbstractValidator<CreateDistributorCommand>
{
    public CreateDistributorValidator()
    {
        RuleFor(x => x.Disturbitor).SetValidator(new CreateDistributorDtoValidator());
    }
}
