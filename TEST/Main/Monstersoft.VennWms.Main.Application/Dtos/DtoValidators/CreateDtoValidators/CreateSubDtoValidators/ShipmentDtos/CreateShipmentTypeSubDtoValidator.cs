using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.ShipmentDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateSubDtoValidators.ShipmentDtos;

public class CreateShipmentTypeSubDtoValidator : AbstractValidator<CreateShipmentTypeSubDto>
{
    public CreateShipmentTypeSubDtoValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
        RuleFor(p => p.Description).NotEmpty().NotNull().MaximumLength(60);
        RuleFor(p => p.IsCodeGenerate).NotNull().WithMessage("{PropertyName} alanı sadece true veya false değeri alabilir.");
        RuleFor(p => p.Format).NotEmpty().NotNull().MaximumLength(20);
        RuleFor(p => p.Counter).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
        RuleFor(p => p.DepositorId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleForEach(x => x.Shipments).SetValidator(new CreateShipmentSubDtoValidator());
    }
}


