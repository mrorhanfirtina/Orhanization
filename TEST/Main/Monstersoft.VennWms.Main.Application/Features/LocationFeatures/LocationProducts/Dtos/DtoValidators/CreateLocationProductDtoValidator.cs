using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProducts.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationProducts.Dtos.DtoValidators;

public class CreateLocationProductDtoValidator : AbstractValidator<CreateLocationProductDto>
{
    public CreateLocationProductDtoValidator()
    {
        RuleFor(p => p.LocationId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.ProductId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.IsForbid).NotNull().WithMessage("{PropertyName} alanı sadece true veya false değeri alabilir.");
    }
}



