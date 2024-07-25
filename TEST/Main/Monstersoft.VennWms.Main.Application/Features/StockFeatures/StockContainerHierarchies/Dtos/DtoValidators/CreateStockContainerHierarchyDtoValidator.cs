using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainerHierarchies.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainers.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockContainerHierarchies.Dtos.DtoValidators;

public class CreateStockContainerHierarchyDtoValidator : AbstractValidator<CreateStockContainerHierarchyDto>
{
    public CreateStockContainerHierarchyDtoValidator()
    {
        RuleFor(p => p.ParentContainerId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.ChildContainerId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(x => x.ParentContainer).SetValidator(new CreateStockContainerDtoValidator());
    }
}
