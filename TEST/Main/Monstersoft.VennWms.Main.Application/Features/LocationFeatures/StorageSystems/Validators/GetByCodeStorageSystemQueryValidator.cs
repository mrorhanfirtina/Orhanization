using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.StorageSystems.Queries.GetByCode;

namespace Monstersoft.VennWms.Main.Application.Features.LocationFeatures.StorageSystems.Validators;

public class GetByCodeStorageSystemQueryValidator : AbstractValidator<GetByCodeStorageSystemQuery>
{
    public GetByCodeStorageSystemQueryValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
    }
}

