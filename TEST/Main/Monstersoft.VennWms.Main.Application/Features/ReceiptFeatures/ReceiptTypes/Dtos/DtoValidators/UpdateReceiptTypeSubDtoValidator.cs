using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.Receipts.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptTypes.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptTypes.Dtos.DtoValidators;

public class UpdateReceiptTypeSubDtoValidator : AbstractValidator<UpdateReceiptTypeSubDto>
{
    public UpdateReceiptTypeSubDtoValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
        RuleFor(p => p.Description).NotEmpty().NotNull().MaximumLength(60);
        RuleFor(p => p.IsCodeGenerate).NotNull().WithMessage("{PropertyName} alanı sadece true veya false değeri alabilir.");
        RuleFor(p => p.Format).NotEmpty().NotNull().MaximumLength(20);
        RuleFor(p => p.Counter).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
        RuleFor(p => p.DepositorId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleForEach(x => x.Receipts).SetValidator(new UpdateReceiptSubDtoValidator());
    }
}


