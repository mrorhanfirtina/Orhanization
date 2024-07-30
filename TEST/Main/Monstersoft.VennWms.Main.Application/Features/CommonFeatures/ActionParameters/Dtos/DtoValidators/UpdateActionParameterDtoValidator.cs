using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameters.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameters.Dtos.DtoValidators;

public class UpdateActionParameterDtoValidator : AbstractValidator<UpdateActionParameterDto>
{
    public UpdateActionParameterDtoValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotNull();
        RuleFor(p => p.Name).NotEmpty().NotNull().MaximumLength(60);
        RuleFor(p => p.Description).NotEmpty().NotNull().MaximumLength(1000);
        RuleFor(p => p.DefaultValue).NotEmpty().NotNull().MaximumLength(60);
        RuleFor(p => p.CategoryId).NotEmpty().NotNull();
    }
}
