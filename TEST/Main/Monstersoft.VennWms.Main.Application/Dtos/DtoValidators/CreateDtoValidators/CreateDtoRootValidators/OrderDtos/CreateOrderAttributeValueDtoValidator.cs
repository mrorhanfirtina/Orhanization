using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.OrderDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.OrderDtos;

public class CreateOrderAttributeValueDtoValidator : AbstractValidator<CreateOrderAttributeValueDto>
{
    public CreateOrderAttributeValueDtoValidator()
    {
        RuleFor(p => p.OrderId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.OrderAttributeId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.Value).NotEmpty().NotNull().MaximumLength(120);
    }
}



