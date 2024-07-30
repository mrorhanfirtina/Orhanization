using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerials.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerials.Validators;

public class GetByIdExpectedSerialQueryValidator : AbstractValidator<GetByIdExpectedSerialQuery>
{
    public GetByIdExpectedSerialQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
