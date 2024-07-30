using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDepositors.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDepositors.Dtos.DtoValidators;

public class UpdateActionParameterDepositorDtoValidator : AbstractValidator<UpdateActionParameterDepositorDto>
{
    public UpdateActionParameterDepositorDtoValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotNull();
        RuleFor(p => p.ActionParameterId).NotEmpty().NotNull();
        RuleFor(p => p.DepositorId).NotEmpty().NotNull();
        RuleFor(p => p.Value).NotEmpty().NotNull().MaximumLength(60);
    }
}
