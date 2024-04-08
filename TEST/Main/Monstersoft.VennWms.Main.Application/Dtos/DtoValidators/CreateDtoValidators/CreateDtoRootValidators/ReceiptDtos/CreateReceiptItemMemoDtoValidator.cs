using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.ReceiptDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.ReceiptDtos;

public class CreateReceiptItemMemoDtoValidator : AbstractValidator<CreateReceiptItemMemoDto>
{
    public CreateReceiptItemMemoDtoValidator()
    {
        RuleFor(p => p.ReceiptItemId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.Description).NotEmpty().NotNull().MaximumLength(50);
        RuleFor(p => p.Text).NotEmpty().NotNull().MaximumLength(500);
    }
}



