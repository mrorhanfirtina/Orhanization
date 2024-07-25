using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialHierarchies.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialHierarchies.Validators;

public class GetByIdSerialHierarchyQueryValidator : AbstractValidator<GetByIdSerialHierarchyQuery>
{
    public GetByIdSerialHierarchyQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
