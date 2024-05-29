using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.PickingTypes.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.PickingTypes.Dtos.DtoValidators;

public class CreatePickingTypeDtoValidator : AbstractValidator<CreatePickingTypeDto>
{
    public CreatePickingTypeDtoValidator()
    {
        RuleFor(x => x.Code).NotNull().NotEmpty().MaximumLength(30);
        RuleFor(x => x.Description).NotNull().NotEmpty().MaximumLength(60);
    }
}
