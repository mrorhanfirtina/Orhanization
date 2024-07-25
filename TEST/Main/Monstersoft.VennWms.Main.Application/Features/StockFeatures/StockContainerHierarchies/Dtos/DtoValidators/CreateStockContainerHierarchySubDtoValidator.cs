using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainerHierarchies.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainerHierarchies.Dtos.DtoValidators;

public class CreateStockContainerHierarchySubDtoValidator : AbstractValidator<CreateStockContainerHierarchySubDto>
{
    public CreateStockContainerHierarchySubDtoValidator()
    {
        RuleFor(p => p.ParentContainerId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.ChildContainerId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
