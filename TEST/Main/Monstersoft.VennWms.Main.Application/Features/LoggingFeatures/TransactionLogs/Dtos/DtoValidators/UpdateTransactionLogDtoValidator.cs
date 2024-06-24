using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStocks.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.TransactionLogs.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.TransactionLogs.Dtos.DtoValidators;

public class UpdateTransactionLogDtoValidator : AbstractValidator<UpdateTransactionLogDto>
{
    public UpdateTransactionLogDtoValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.UserId).NotEmpty().InclusiveBetween(0, int.MaxValue).WithMessage("{PropertyName} alanı boş olamaz veya sıfıra eşit olamaz.");

        RuleFor(p => p.OrderId).Null().NotEmpty().When(p => p.OrderId != null).NotEqual(Guid.Empty).When(p => p.OrderId != null).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.OrderItemId).Null().NotEmpty().When(p => p.OrderItemId != null).NotEqual(Guid.Empty).When(p => p.OrderItemId != null).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.ReturnId).Null().NotEmpty().When(p => p.ReturnId != null).NotEqual(Guid.Empty).When(p => p.ReturnId != null).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.ReturnItemId).Null().NotEmpty().When(p => p.ReturnItemId != null).NotEqual(Guid.Empty).When(p => p.ReturnItemId != null).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.ReceiptId).Null().NotEmpty().When(p => p.ReceiptId != null).NotEqual(Guid.Empty).When(p => p.ReceiptId != null).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.ReceiptItemId).Null().NotEmpty().When(p => p.ReceiptItemId != null).NotEqual(Guid.Empty).When(p => p.ReceiptItemId != null).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.WorkTaskId).Null().NotEmpty().When(p => p.WorkTaskId != null).NotEqual(Guid.Empty).When(p => p.WorkTaskId != null).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.DepositorId).Null().NotEmpty().When(p => p.DepositorId != null).NotEqual(Guid.Empty).When(p => p.DepositorId != null).WithMessage("{PropertyName} alanı boş Guid olamaz.");

        RuleForEach(x => x.LogStocks).SetValidator(new UpdateLogStockSubDtoValidator());
    }
}



