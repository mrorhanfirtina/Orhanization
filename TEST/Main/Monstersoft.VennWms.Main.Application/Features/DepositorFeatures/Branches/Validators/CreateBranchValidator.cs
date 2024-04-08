using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.DepositorDtos;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Branches.Commands.Create;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Branches.Validators;

public class CreateBranchValidator : AbstractValidator<CreateBranchCommand>
{
    public CreateBranchValidator()
    {
        RuleFor(x => x.Branch).SetValidator(new CreateBranchDtoValidator());
    }
}
