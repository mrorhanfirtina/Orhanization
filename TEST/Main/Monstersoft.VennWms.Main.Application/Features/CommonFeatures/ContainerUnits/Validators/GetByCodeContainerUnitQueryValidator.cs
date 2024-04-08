using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Queries.GetByCode;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Validators;

public class GetByCodeContainerUnitQueryValidator : AbstractValidator<GetByCodeContainerUnitQuery>
{
    public GetByCodeContainerUnitQueryValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
    }
}

