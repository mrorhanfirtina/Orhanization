using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.BufferLocations.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.BufferLocations.Dtos.DtoValidators;


namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.BufferLocations.Validators;

public class UpdateBufferLocationValidator : AbstractValidator<UpdateBufferLocationCommand>
{
    public UpdateBufferLocationValidator()
    {
        RuleFor(x => x.BufferLocation).SetValidator(new UpdateBufferLocationDtoValidator());
    }
}
