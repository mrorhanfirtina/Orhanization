using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.PickingTypes.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.PickingTypes.Dtos.DtoValidators;

public class UpdatePickingTypeDtoValidator : AbstractValidator<UpdatePickingTypeDto>
{
    public UpdatePickingTypeDtoValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
        RuleFor(x => x.Code).NotNull().NotEmpty().MaximumLength(30);
        RuleFor(x => x.Description).NotNull().NotEmpty().MaximumLength(60);
    }
}
