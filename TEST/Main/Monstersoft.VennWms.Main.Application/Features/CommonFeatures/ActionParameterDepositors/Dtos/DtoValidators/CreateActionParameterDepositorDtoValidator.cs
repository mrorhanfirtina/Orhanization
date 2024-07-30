using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDepositors.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDepositors.Dtos.DtoValidators;

public class CreateActionParameterDepositorDtoValidator : AbstractValidator<CreateActionParameterDepositorDto>
{
    public CreateActionParameterDepositorDtoValidator()
    {
        RuleFor(p => p.ActionParameterId).NotEmpty().NotNull();
        RuleFor(p => p.DepositorId).NotEmpty().NotNull();
        RuleFor(p => p.Value).NotEmpty().NotNull().MaximumLength(60);
    }
}
