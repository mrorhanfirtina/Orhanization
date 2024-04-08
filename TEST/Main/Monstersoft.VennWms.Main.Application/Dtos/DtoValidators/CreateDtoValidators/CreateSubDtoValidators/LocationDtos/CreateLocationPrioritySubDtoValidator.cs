using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.SubDtos.LocationDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateSubDtoValidators.LocationDtos;

public class CreateLocationPrioritySubDtoValidator : AbstractValidator<CreateLocationPrioritySubDto>
{
    public CreateLocationPrioritySubDtoValidator()
    {
        RuleFor(p => p.InboundPriority).InclusiveBetween(0, int.MaxValue);
        RuleFor(p => p.OutboundPriority).InclusiveBetween(0, int.MaxValue);
    }
}
