using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.SiteDepositors.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.SiteDepositors.Dtos.DtoValidators;

public class UpdateSiteDepositorSubDtoValidator : AbstractValidator<UpdateSiteDepositorSubDto>
{
    public UpdateSiteDepositorSubDtoValidator()
    {
        RuleFor(p => p.DepositorId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
