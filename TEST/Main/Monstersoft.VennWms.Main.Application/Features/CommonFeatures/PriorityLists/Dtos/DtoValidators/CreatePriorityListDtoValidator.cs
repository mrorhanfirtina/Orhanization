using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.PriorityLists.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.PriorityLists.Dtos.DtoValidators;

public class CreatePriorityListDtoValidator : AbstractValidator<CreatePriorityListDto>
{
    public CreatePriorityListDtoValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
        RuleFor(p => p.Description).NotEmpty().NotNull().MaximumLength(50);
        RuleFor(p => p.Priority).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
    }
}
