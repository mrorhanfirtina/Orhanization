using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.ProductDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.ProductDtos;

public class CreateProductDepositorDtoValidator : AbstractValidator<CreateProductDepositorDto>
{
    public CreateProductDepositorDtoValidator()
    {
        RuleFor(p => p.ProductId).NotEmpty().NotNull().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.DepositorId).NotEmpty().NotNull().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
