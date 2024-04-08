using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.BarcodeDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateSubDtoValidators.BarcodeDtos;

public class UpdateBarcodeAreaSubDtoValidator : AbstractValidator<UpdateBarcodeAreaSubDto>
{
    public UpdateBarcodeAreaSubDtoValidator()
    {
        RuleFor(p => p.QueryField).NotEmpty().NotNull().MaximumLength(60);
        RuleFor(p => p.TextField).NotEmpty().NotNull().MaximumLength(60);
    }
}


