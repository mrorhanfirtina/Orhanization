using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.SiteDepositors.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.SiteDepositors.Dtos.DtoValidators;

public class UpdateSiteDepositorDtoValidator : AbstractValidator<UpdateSiteDepositorDto>
{
    public UpdateSiteDepositorDtoValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotNull().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.SiteId).NotEmpty().NotNull().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.DepositorId).NotEmpty().NotNull().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}


