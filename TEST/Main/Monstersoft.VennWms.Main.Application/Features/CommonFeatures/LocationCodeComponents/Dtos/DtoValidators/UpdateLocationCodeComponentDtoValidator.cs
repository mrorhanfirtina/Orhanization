using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.LocationCodeComponents.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.LocationCodeComponents.Dtos.DtoValidators;

public class UpdateLocationCodeComponentDtoValidator : AbstractValidator<UpdateLocationCodeComponentDto>
{
    public UpdateLocationCodeComponentDtoValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
        RuleFor(x => x.Description).NotNull().NotEmpty().MaximumLength(30);
        RuleFor(x => x.TableName).NotNull().NotEmpty().MaximumLength(30);
        RuleFor(x => x.FieldName).NotNull().NotEmpty().MaximumLength(30);
        RuleFor(x => x.FieldCode).NotNull().NotEmpty().MaximumLength(10);
    }
}
