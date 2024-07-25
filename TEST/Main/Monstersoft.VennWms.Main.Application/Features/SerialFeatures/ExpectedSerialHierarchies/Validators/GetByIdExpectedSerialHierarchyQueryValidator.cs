using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerialHierarchies.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerialHierarchies.Validators;

public class GetByIdExpectedSerialHierarchyQueryValidator : AbstractValidator<GetByIdExpectedSerialHierarchyQuery>
{
    public GetByIdExpectedSerialHierarchyQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
