using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Distributors.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Distributors.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Distributors.Validators;

public class UpdateDistributorValidator : AbstractValidator<UpdateDistributorCommand>
{
    public UpdateDistributorValidator()
    {
        RuleFor(x => x.Disturbitor).SetValidator(new UpdateDistributorDtoValidator());
    }
}
