using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Statuses.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Statuses.Dtos.DtoValidators;

public class CreateStatusDtoValidator : AbstractValidator<CreateStatusDto>
{
    public CreateStatusDtoValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
        RuleFor(p => p.Description).NotEmpty().NotNull().MaximumLength(60);
    }
}



