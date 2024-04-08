using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.DepositorDtos;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Distributors.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Distributors.Validators;

public class UpdateDistributorValidator : AbstractValidator<UpdateDistributorCommand>
{
    public UpdateDistributorValidator()
    {
        RuleFor(x => x.Disturbitor).SetValidator(new UpdateDistributorDtoValidator());
    }
}
