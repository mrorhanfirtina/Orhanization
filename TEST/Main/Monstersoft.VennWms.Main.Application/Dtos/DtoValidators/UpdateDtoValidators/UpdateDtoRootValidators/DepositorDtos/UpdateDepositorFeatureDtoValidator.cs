using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.DepositorDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.DepositorDtos;

public class UpdateDepositorFeatureDtoValidator : AbstractValidator<UpdateDepositorFeatureDto>
{
    public UpdateDepositorFeatureDtoValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.DepositorId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.GenerateSsccLed).NotNull().WithMessage("{PropertyName} alanı sadece true veya false değeri alabilir.");
        RuleFor(p => p.OrderModifyLed).NotNull().WithMessage("{PropertyName} alanı sadece true veya false değeri alabilir.");
        RuleFor(p => p.ForbidNewReceiptLineLed).NotNull().WithMessage("{PropertyName} alanı sadece true veya false değeri alabilir.");
        RuleFor(p => p.AllowDuplicateBarcodeLed).NotNull().WithMessage("{PropertyName} alanı sadece true veya false değeri alabilir.");
        RuleFor(p => p.ForceTaskStockLed).NotNull().WithMessage("{PropertyName} alanı sadece true veya false değeri alabilir.");
        RuleFor(p => p.ForbidTransferReservedLed).NotNull().WithMessage("{PropertyName} alanı sadece true veya false değeri alabilir.");
        RuleFor(p => p.ChangeStockWithTaskLed).NotNull().WithMessage("{PropertyName} alanı sadece true veya false değeri alabilir.");
        RuleFor(p => p.ManualReceiptCompletionLed).NotNull().WithMessage("{PropertyName} alanı sadece true veya false değeri alabilir.");
        RuleFor(p => p.ManualReturnCompletionLed).NotNull().WithMessage("{PropertyName} alanı sadece true veya false değeri alabilir.");
    }
}
