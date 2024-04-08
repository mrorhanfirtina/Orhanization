using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.DepositorDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateSubDtoValidators.DepositorDtos;

public class UpdateDepositorSubDtoValidator : AbstractValidator<UpdateDepositorSubDto>
{
    public UpdateDepositorSubDtoValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
        RuleFor(x => x.DepositorFeature).NotNull().SetValidator(new UpdateDepositorFeatureSubDtoValidator());
    }
}


