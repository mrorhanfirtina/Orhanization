using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameters.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameters.Dtos.DtoValidators;

public class CreateActionParameterDtoValidator : AbstractValidator<CreateActionParameterDto>
{
    public CreateActionParameterDtoValidator()
    {
        RuleFor(p => p.Name).NotEmpty().NotNull().MaximumLength(60);
        RuleFor(p => p.Description).NotEmpty().NotNull().MaximumLength(100);
        RuleFor(p => p.DefaultValue).NotEmpty().NotNull().MaximumLength(60);
        RuleFor(p => p.CategoryId).NotEmpty().NotNull();
    }
}
