using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodeAreas.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodeAreas.Dtos.DtoValidators;

public class CreateBarcodeAreaSubDtoValidator : AbstractValidator<CreateBarcodeAreaSubDto>
{
    public CreateBarcodeAreaSubDtoValidator()
    {
        RuleFor(p => p.QueryField).NotEmpty().NotNull().MaximumLength(60);
        RuleFor(p => p.TextField).NotEmpty().NotNull().MaximumLength(60);
    }
}


