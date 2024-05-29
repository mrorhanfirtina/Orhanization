﻿using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Branches.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Distributors.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.OrderShipItems.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentAttributeValues.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentMemos.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentTypes.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.Shipments.Dtos.DtoValidators;

public class UpdateShipmentSubDtoValidator : AbstractValidator<UpdateShipmentSubDto>
{
    public UpdateShipmentSubDtoValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
        RuleFor(p => p.DepositorId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.DistributorId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.BranchId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.ShipmentTypeId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.ExpectedDate).GreaterThanOrEqualTo(DateTime.MinValue).WithMessage("{PropertyName}, geçerli bir tarih olmalı.").LessThanOrEqualTo(DateTime.MaxValue).WithMessage("{PropertyName}, geçerli bir tarih olmalı.");
        RuleFor(x => x.Distributor).SetValidator(new UpdateDistributorSubDtoValidator());
        RuleFor(x => x.Branch).SetValidator(new UpdateBranchSubDtoValidator());
        RuleFor(x => x.ShipmentType).SetValidator(new UpdateShipmentTypeSubDtoValidator());
        RuleForEach(x => x.ShipmentAttributeValues).SetValidator(new UpdateShipmentAttributeValueSubDtoValidator());
        RuleForEach(x => x.ShipmentMemos).SetValidator(new UpdateShipmentMemoSubDtoValidator());
        RuleForEach(x => x.OrderShipItems).SetValidator(new UpdateOrderShipItemSubDtoValidator());
    }
}

