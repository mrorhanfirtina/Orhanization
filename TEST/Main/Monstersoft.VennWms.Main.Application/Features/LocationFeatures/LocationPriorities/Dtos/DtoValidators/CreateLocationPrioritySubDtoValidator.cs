using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationPriorities.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.LocationPriorities.Dtos.DtoValidators;

public class CreateLocationPrioritySubDtoValidator : AbstractValidator<CreateLocationPrioritySubDto>
{
    public CreateLocationPrioritySubDtoValidator()
    {
        RuleFor(p => p.InboundPriority).InclusiveBetween(0, int.MaxValue);
        RuleFor(p => p.OutboundPriority).InclusiveBetween(0, int.MaxValue);
    }
}
