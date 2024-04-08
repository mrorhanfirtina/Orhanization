using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.BarcodeDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateSubDtoValidators.BarcodeDtos;

public class CreateBarcodeAreaSubDtoValidator : AbstractValidator<CreateBarcodeAreaSubDto>
{
    public CreateBarcodeAreaSubDtoValidator()
    {
        RuleFor(p => p.QueryField).NotEmpty().NotNull().MaximumLength(60);
        RuleFor(p => p.TextField).NotEmpty().NotNull().MaximumLength(60);
    }
}


