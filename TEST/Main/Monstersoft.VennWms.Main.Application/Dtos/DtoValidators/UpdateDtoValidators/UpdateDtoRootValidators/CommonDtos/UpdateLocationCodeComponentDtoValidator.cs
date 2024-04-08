using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.CommonDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.CommonDtos;

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
