using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Receivers.Queries.GetByCode;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Receivers.Validators;

public class GetByCodeReceiverQueryValidator : AbstractValidator<GetByCodeReceiverQuery>
{
    public GetByCodeReceiverQueryValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
    }
}

