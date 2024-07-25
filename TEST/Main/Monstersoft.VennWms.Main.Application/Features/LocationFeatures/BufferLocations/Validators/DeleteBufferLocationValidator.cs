using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.BufferLocations.Commands.Delete;


namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.BufferLocations.Validators;

public class DeleteBufferLocationValidator : AbstractValidator<DeleteBufferLocationCommand>
{
    public DeleteBufferLocationValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
