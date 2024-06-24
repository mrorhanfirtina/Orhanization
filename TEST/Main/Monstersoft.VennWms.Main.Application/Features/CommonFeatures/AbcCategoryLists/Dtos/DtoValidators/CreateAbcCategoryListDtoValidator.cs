using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.AbcCategoryLists.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.AbcCategoryLists.Dtos.DtoValidators;

public class CreateAbcCategoryListDtoValidator : AbstractValidator<CreateAbcCategoryListDto>
{
    public CreateAbcCategoryListDtoValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
        RuleFor(p => p.Description).NotEmpty().NotNull().MaximumLength(50);
        RuleFor(p => p.Priority).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
    }
}
