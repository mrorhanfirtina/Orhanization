using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ProgressStatuses.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ProgressStatuses.Dtos.DtoValidators;

public class UpdateProgressStatusDtoValidator : AbstractValidator<UpdateProgressStatusDto>
{
    public UpdateProgressStatusDtoValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
        RuleFor(p => p.Description).NotEmpty().NotNull().MaximumLength(60);
    }
}



