using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderMemos.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderMemos.Dtos.DtoValidators;

public class UpdateOrderMemoDtoValidator : AbstractValidator<UpdateOrderMemoDto>
{
    public UpdateOrderMemoDtoValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.OrderId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.Description).NotEmpty().NotNull().MaximumLength(50);
        RuleFor(p => p.Text).NotEmpty().NotNull().MaximumLength(500);
    }
}



