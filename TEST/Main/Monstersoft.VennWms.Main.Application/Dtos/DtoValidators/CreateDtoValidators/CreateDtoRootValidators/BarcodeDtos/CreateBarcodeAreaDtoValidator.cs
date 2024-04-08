using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.BarcodeDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.BarcodeDtos;

public class CreateBarcodeAreaDtoValidator : AbstractValidator<CreateBarcodeAreaDto>
{
    public CreateBarcodeAreaDtoValidator()
    {
        RuleFor(p => p.BarcodeId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.QueryField).NotEmpty().NotNull().MaximumLength(60);
        RuleFor(p => p.TextField).NotEmpty().NotNull().MaximumLength(60);
    }
}



