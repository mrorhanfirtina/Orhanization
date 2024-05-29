﻿using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.BarcodeSuppliers.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductBarcodes.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductBarcodes.Dtos.DtoValidators;

public class UpdateProductBarcodeSubDtoValidator : AbstractValidator<UpdateProductBarcodeSubDto>
{
    public UpdateProductBarcodeSubDtoValidator()
    {
        RuleFor(p => p.BarcodeString).NotEmpty().NotNull().MaximumLength(140);
        RuleForEach(x => x.BarcodeSuppliers).SetValidator(new UpdateBarcodeSupplierSubDtoValidator());
    }
}


