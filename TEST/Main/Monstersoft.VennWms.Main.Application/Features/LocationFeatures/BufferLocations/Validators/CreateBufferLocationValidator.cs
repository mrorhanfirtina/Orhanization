using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.BufferLocations.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.BufferLocations.Dtos.DtoValidators;


namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.BufferLocations.Validators;

public class CreateBufferLocationValidator : AbstractValidator<CreateBufferLocationCommand>
{
    public CreateBufferLocationValidator()
    {
        RuleFor(x => x.BufferLocation).SetValidator(new CreateBufferLocationDtoValidator());
    }
}
