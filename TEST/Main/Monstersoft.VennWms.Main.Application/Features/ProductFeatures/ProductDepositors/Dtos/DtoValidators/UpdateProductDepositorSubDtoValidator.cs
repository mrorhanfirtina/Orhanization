using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductDepositors.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductDepositors.Dtos.DtoValidators;

public class UpdateProductDepositorSubDtoValidator : AbstractValidator<UpdateProductDepositorSubDto>
{
    public UpdateProductDepositorSubDtoValidator()
    {
        RuleFor(p => p.DepositorId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
