using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.ReceiptDtos;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateSubDtoValidators.ReceiptDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.ReceiptDtos;

public class CreateReceiptTypeDtoValidator : AbstractValidator<CreateReceiptTypeDto>
{
    public CreateReceiptTypeDtoValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
        RuleFor(p => p.Description).NotEmpty().NotNull().MaximumLength(60);
        RuleFor(p => p.IsCodeGenerate).NotNull().WithMessage("{PropertyName} alanı sadece true veya false değeri alabilir.");
        RuleFor(p => p.Format).NotEmpty().NotNull().MaximumLength(20);
        RuleFor(p => p.Counter).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
        RuleForEach(x => x.Receipts).SetValidator(new CreateReceiptSubDtoValidator());
    }
}



