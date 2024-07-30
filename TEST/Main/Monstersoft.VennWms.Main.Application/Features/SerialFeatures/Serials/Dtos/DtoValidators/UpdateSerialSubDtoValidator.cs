using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.Serials.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.Serials.Dtos.DtoValidators;

public class UpdateSerialSubDtoValidator : AbstractValidator<UpdateSerialSubDto>
{
    public UpdateSerialSubDtoValidator()
    {
        RuleFor(p => p.StockPackTypeId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.StockPackTypeId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.DepositorCompanyId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.ReceiptId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.ReceiptItemId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.SerialNo).NotEmpty().NotNull().MaximumLength(30);
        RuleFor(p => p.SSCC).NotEmpty().NotNull().MaximumLength(30);
    }
}
