using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoTypes.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PurchaseOrders.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoTypes.Dtos.DtoValidators;

public class UpdatePoTypeDtoValidator : AbstractValidator<UpdatePoTypeDto>
{
    public UpdatePoTypeDtoValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
        RuleFor(p => p.Description).NotEmpty().NotNull().MaximumLength(60);
        RuleFor(p => p.IsCodeGenerate).NotNull().WithMessage("{PropertyName} alanı sadece true veya false değeri alabilir.");
        RuleFor(p => p.Format).NotEmpty().NotNull().MaximumLength(20);
        RuleFor(p => p.Counter).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
        RuleForEach(x => x.PurchaseOrders).SetValidator(new UpdatePurchaseOrderSubDtoValidator());
    }
}



