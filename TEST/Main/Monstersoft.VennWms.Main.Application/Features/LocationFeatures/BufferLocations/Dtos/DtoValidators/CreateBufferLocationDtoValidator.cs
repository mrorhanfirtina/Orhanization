using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.BufferLocations.Dtos.CreateDtos;


namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.BufferLocations.Dtos.DtoValidators;

public class CreateBufferLocationDtoValidator : AbstractValidator<CreateBufferLocationDto>
{
    public CreateBufferLocationDtoValidator()
    {
        RuleFor(p => p.LocationId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.BuffLocationId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.IsBefore).NotNull().WithMessage("{PropertyName} alanı sadece true veya false değeri alabilir.");
    }
}
