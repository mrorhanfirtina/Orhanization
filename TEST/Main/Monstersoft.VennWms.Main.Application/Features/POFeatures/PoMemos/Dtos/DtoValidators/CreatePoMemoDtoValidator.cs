using FluentValidation;

namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoMemos.Dtos.DtoValidators;

public class CreatePoMemoDtoValidator : AbstractValidator<CreatePoMemoDto>
{
    public CreatePoMemoDtoValidator()
    {
        RuleFor(p => p.PurchaseOrderId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.Description).NotEmpty().NotNull().MaximumLength(50);
        RuleFor(p => p.Text).NotEmpty().NotNull().MaximumLength(500);
    }
}



