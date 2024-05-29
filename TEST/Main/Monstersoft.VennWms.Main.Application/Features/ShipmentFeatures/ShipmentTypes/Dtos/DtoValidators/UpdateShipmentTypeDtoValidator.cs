using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentTypes.Dtos.DtoValidators;

public class UpdateShipmentTypeDtoValidator : AbstractValidator<UpdateShipmentTypeDto>
{
    public UpdateShipmentTypeDtoValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
        RuleFor(p => p.Description).NotEmpty().NotNull().MaximumLength(60);
        RuleFor(p => p.IsCodeGenerate).NotNull().WithMessage("{PropertyName} alanı sadece true veya false değeri alabilir.");
        RuleFor(p => p.Format).NotEmpty().NotNull().MaximumLength(20);
        RuleFor(p => p.Counter).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
        RuleForEach(x => x.Shipments).SetValidator(new UpdateShipmentSubDtoValidator());
    }
}



