using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.BarcodeDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.BarcodeDtos;

public class UpdateBarcodeAreaDtoValidator : AbstractValidator<UpdateBarcodeAreaDto>
{
    public UpdateBarcodeAreaDtoValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.BarcodeId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.QueryField).NotEmpty().NotNull().MaximumLength(60);
        RuleFor(p => p.TextField).NotEmpty().NotNull().MaximumLength(60);
    }
}



