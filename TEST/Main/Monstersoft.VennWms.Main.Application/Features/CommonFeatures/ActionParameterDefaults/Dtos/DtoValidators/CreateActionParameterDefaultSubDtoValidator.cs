using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDefaults.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDefaults.Dtos.DtoValidators;

public class CreateActionParameterDefaultSubDtoValidator : AbstractValidator<CreateActionParameterDefaultSubDto>
{
    public CreateActionParameterDefaultSubDtoValidator()
    {
        RuleFor(p => p.ActionParameterId).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
        RuleFor(p => p.Value).NotEmpty().NotNull().MaximumLength(60);
    }
}
