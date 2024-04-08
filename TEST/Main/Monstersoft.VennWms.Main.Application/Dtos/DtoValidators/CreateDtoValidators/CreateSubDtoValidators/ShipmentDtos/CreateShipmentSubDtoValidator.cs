using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.ShipmentDtos;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateSubDtoValidators.DepositorDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateSubDtoValidators.ShipmentDtos;

public class CreateShipmentSubDtoValidator : AbstractValidator<CreateShipmentSubDto>
{
    public CreateShipmentSubDtoValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
        RuleFor(p => p.DepositorId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.DistributorId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.BranchId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.ShipmentTypeId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.ExpectedDate).GreaterThanOrEqualTo(DateTime.MinValue).WithMessage("{PropertyName}, geçerli bir tarih olmalı.").LessThanOrEqualTo(DateTime.MaxValue).WithMessage("{PropertyName}, geçerli bir tarih olmalı.");
        RuleFor(x => x.Distributor).SetValidator(new CreateDistributorSubDtoValidator());
        RuleFor(x => x.Branch).SetValidator(new CreateBranchSubDtoValidator());
        RuleFor(x => x.ShipmentType).SetValidator(new CreateShipmentTypeSubDtoValidator());
        RuleForEach(x => x.ShipmentAttributeValues).SetValidator(new CreateShipmentAttributeValueSubDtoValidator());
        RuleForEach(x => x.ShipmentMemos).SetValidator(new CreateShipmentMemoSubDtoValidator());
        RuleForEach(x => x.OrderShipItems).SetValidator(new CreateOrderShipItemSubDtoValidator());
    }
}


