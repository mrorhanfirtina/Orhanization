using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodeAreas.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodeAreas.Dtos.DtoValidators;

public class UpdateBarcodeAreaSubDtoValidator : AbstractValidator<UpdateBarcodeAreaSubDto>
{
    public UpdateBarcodeAreaSubDtoValidator()
    {
        RuleFor(p => p.QueryField).NotEmpty().NotNull().MaximumLength(60);
        RuleFor(p => p.TextField).NotEmpty().NotNull().MaximumLength(60);
    }
}


