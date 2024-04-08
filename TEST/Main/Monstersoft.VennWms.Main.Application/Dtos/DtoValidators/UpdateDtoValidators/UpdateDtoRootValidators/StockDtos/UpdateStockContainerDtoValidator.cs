using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.StockDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.StockDtos;

public class UpdateStockContainerDtoValidator : AbstractValidator<UpdateStockContainerDto>
{
    public UpdateStockContainerDtoValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.Sscc).NotEmpty().NotNull().MaximumLength(30);
        RuleFor(p => p.ContainerUnitId).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
    }
}



