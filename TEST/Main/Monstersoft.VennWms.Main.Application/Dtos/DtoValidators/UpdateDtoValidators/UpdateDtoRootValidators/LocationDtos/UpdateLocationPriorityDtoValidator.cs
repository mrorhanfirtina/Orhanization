using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.RootDtos.LocationDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.LocationDtos;

public class UpdateLocationPriorityDtoValidator : AbstractValidator<UpdateLocationPriorityDto>
{
    public UpdateLocationPriorityDtoValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.LocationId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.InboundPriority).InclusiveBetween(0, int.MaxValue);
        RuleFor(p => p.OutboundPriority).InclusiveBetween(0, int.MaxValue);
    }
}

