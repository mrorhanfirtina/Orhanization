using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ProgressStatuses.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ProgressStatuses.Dtos.DtoValidators;

public class CreateProgressStatusDtoValidator : AbstractValidator<CreateProgressStatusDto>
{
    public CreateProgressStatusDtoValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
        RuleFor(p => p.Description).NotEmpty().NotNull().MaximumLength(60);
    }
}



