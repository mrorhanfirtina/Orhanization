using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributeValues.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributeValues.Dtos.DtoValidators;

public class UpdateOrderAttributeValueSubDtoValidator : AbstractValidator<UpdateOrderAttributeValueSubDto>
{
    public UpdateOrderAttributeValueSubDtoValidator()
    {
        RuleFor(p => p.OrderAttributeId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.Value).NotEmpty().NotNull().MaximumLength(120);
    }
}


