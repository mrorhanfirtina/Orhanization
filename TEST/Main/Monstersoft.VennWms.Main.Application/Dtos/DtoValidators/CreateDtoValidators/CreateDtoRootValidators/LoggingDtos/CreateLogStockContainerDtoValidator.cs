using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.LoggingDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.LoggingDtos;

public class CreateLogStockContainerDtoValidator : AbstractValidator<CreateLogStockContainerDto>
{
    public CreateLogStockContainerDtoValidator()
    {
        RuleFor(p => p.LogStockId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.FromContainerId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.ToContainerId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.FromContainerSSCC).NotEmpty().NotNull().MaximumLength(30);
        RuleFor(p => p.ToContainerSSCC).NotEmpty().NotNull().MaximumLength(30);
        RuleFor(p => p.FromContainerTypeId).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
        RuleFor(p => p.ToContainerTypeId).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
    }
}



