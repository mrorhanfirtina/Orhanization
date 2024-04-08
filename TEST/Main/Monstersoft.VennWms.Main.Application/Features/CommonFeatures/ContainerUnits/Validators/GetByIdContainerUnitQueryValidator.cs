using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Validators;

public class GetByIdContainerUnitQueryValidator : AbstractValidator<GetByIdContainerUnitQuery>
{
    public GetByIdContainerUnitQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
    }
}
