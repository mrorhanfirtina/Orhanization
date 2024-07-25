using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainerHierarchies.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainerHierarchies.Dtos.DtoValidators;

public class UpdateStockContainerHierarchySubDtoValidator : AbstractValidator<UpdateStockContainerHierarchySubDto>
{
    public UpdateStockContainerHierarchySubDtoValidator()
    {
        RuleFor(p => p.ParentContainerId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.ChildContainerId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
