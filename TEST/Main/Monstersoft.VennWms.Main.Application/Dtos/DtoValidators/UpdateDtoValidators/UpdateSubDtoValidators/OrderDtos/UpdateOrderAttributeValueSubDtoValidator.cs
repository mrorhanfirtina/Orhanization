using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.OrderDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoAggregateValidators.OrderDtos;

public class UpdateOrderAttributeValueSubDtoValidator : AbstractValidator<UpdateOrderAttributeValueSubDto>
{
    public UpdateOrderAttributeValueSubDtoValidator()
    {
        RuleFor(p => p.OrderAttributeId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.Value).NotEmpty().NotNull().MaximumLength(120);
    }
}


