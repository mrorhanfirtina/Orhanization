using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.LocationDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateSubDtoValidators.LocationDtos;

public class UpdateLocationPrioritySubDtoValidator : AbstractValidator<UpdateLocationPrioritySubDto>
{
    public UpdateLocationPrioritySubDtoValidator()
    {
        RuleFor(p => p.InboundPriority).InclusiveBetween(0, int.MaxValue);
        RuleFor(p => p.OutboundPriority).InclusiveBetween(0, int.MaxValue);
    }
}
