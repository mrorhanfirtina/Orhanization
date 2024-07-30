using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.BufferLocations.Queries.GetById;


namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.BufferLocations.Validators;

public class GetByIdBufferLocationQueryValidator : AbstractValidator<GetByIdBufferLocationQuery>
{
    public GetByIdBufferLocationQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
