using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.LocationCodeComponents.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.LocationCodeComponents.Dtos.DtoValidators;

public class CreateLocationCodeComponentDtoValidator : AbstractValidator<CreateLocationCodeComponentDto>
{
    public CreateLocationCodeComponentDtoValidator()
    {
        RuleFor(x => x.Description).NotNull().NotEmpty().MaximumLength(30);
        RuleFor(x => x.TableName).NotNull().NotEmpty().MaximumLength(30);
        RuleFor(x => x.FieldName).NotNull().NotEmpty().MaximumLength(30);
        RuleFor(x => x.FieldCode).NotNull().NotEmpty().MaximumLength(30);
    }
}
