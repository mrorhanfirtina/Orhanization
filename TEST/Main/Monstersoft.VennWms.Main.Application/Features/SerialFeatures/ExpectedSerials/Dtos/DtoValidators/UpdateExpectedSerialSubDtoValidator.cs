using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerials.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerials.Dtos.DtoValidators;

public class UpdateExpectedSerialSubDtoValidator : AbstractValidator<UpdateExpectedSerialSubDto>
{
    public UpdateExpectedSerialSubDtoValidator()
    {
        RuleFor(p => p.ItemUnitId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.DepositorId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.DepositorCompanyId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.ReceiptId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.ReceiptItemId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.SerialNo).NotEmpty().NotNull().MaximumLength(30);
        RuleFor(p => p.SSCC).NotEmpty().NotNull().MaximumLength(30);
    }
}
