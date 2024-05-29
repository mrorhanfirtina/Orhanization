using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategoryLists.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategoryLists.Dtos.DtoValidators;

public class UpdateProductCategoryListDtoValidator : AbstractValidator<UpdateProductCategoryListDto>
{
    public UpdateProductCategoryListDtoValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
        RuleFor(p => p.Description).NotEmpty().NotNull().MaximumLength(50);
        RuleFor(p => p.Priority).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
        RuleFor(p => p.DepositorCompanyId).NotEmpty().NotNull().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}







