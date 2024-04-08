using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.PurchaseOrderDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.PurchaseOrderDtos;

public class CreatePoAttributeDtoValidator : AbstractValidator<CreatePoAttributeDto>
{
    public CreatePoAttributeDtoValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
        RuleFor(p => p.Description).NotEmpty().NotNull().MaximumLength(60);
        RuleFor(p => p.AttributeInputTypeId).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
        RuleFor(p => p.IsNecessary).NotNull().WithMessage("{PropertyName} alanı sadece true veya false değeri alabilir.");
    }
}



