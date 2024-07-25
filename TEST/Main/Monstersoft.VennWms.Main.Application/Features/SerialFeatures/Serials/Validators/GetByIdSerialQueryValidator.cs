using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.Serials.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.Serials.Validators;

public class GetByIdSerialQueryValidator : AbstractValidator<GetByIdSerialQuery>
{
    public GetByIdSerialQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
