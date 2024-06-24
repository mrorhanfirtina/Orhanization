using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.AbcCategoryLists.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.AbcCategoryLists.Dtos.DtoValidators;

public class UpdateAbcCategoryListDtoValidator : AbstractValidator<UpdateAbcCategoryListDto>
{
    public UpdateAbcCategoryListDtoValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
        RuleFor(p => p.Description).NotEmpty().NotNull().MaximumLength(50);
        RuleFor(p => p.Priority).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
    }
}







