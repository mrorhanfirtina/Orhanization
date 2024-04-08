using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.LocationDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateSubDtoValidators.LocationDtos;

public class CreateLocationProductSubDtoValidator : AbstractValidator<CreateLocationProductSubDto>
{
    public CreateLocationProductSubDtoValidator()
    {
        RuleFor(p => p.ProductId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.IsForbid).NotNull().NotEmpty();
    }
}
