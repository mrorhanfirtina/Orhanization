using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialLogs.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialLogs.Dtos.DtoValidators;

public class UpdateSerialLogSubDtoValidator : AbstractValidator<UpdateSerialLogSubDto>
{
    public UpdateSerialLogSubDtoValidator()
    {
        RuleFor(p => p.TransactionTypeId).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
        RuleFor(p => p.TransactionLogId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.DepositorId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.DepositorCompanyId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.ReceiptId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.SerialNo).NotEmpty().NotNull().MaximumLength(30);
        RuleFor(p => p.SSCC).NotEmpty().NotNull().MaximumLength(30);
    }
}
