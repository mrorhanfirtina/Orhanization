using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.DepositorDtos;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Branches.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Branches.Validators;

public class UpdateBranchValidator : AbstractValidator<UpdateBranchCommand>
{
    public UpdateBranchValidator()
    {
        RuleFor(x => x.Branch).SetValidator(new UpdateBranchDtoValidator());
    }
}
