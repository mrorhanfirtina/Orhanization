using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodeAreas.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.BarcodeAreas.Dtos.DtoValidators;

public class CreateBarcodeAreaDtoValidator : AbstractValidator<CreateBarcodeAreaDto>
{
    public CreateBarcodeAreaDtoValidator()
    {
        RuleFor(p => p.BarcodeId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.QueryField).NotEmpty().NotNull().MaximumLength(60);
        RuleFor(p => p.TextField).NotEmpty().NotNull().MaximumLength(60);
    }
}



