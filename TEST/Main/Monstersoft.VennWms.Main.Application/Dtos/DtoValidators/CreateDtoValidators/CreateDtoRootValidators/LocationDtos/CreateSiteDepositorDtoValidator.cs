using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.LocationDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.LocationDtos;

public class CreateSiteDepositorDtoValidator : AbstractValidator<CreateSiteDepositorDto>
{
    public CreateSiteDepositorDtoValidator()
    {
        RuleFor(p => p.SiteId).NotEmpty().NotNull().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.DepositorId).NotEmpty().NotNull().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}

