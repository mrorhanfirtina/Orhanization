using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationPriorities.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationPriorities.Dtos.DtoValidators;

public class UpdateLocationPrioritySubDtoValidator : AbstractValidator<UpdateLocationPrioritySubDto>
{
    public UpdateLocationPrioritySubDtoValidator()
    {
        RuleFor(p => p.InboundPriority).InclusiveBetween(0, int.MaxValue);
        RuleFor(p => p.OutboundPriority).InclusiveBetween(0, int.MaxValue);
    }
}
