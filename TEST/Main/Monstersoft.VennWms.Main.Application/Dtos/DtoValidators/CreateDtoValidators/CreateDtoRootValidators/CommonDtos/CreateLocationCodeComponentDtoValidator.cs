using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.CommonDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.CommonDtos;

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
