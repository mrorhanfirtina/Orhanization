using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.LocationDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.LocationDtos;

public class CreateLocationProductDtoValidator : AbstractValidator<CreateLocationProductDto>
{
    public CreateLocationProductDtoValidator()
    {
        RuleFor(p => p.LocationId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.ProductId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.IsForbid).NotNull().WithMessage("{PropertyName} alanı sadece true veya false değeri alabilir.");
    }
}



