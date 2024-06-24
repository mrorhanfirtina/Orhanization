using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Receivers.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Receivers.Validators;

public class GetByIdReceiverQueryValidator : AbstractValidator<GetByIdReceiverQuery>
{
    public GetByIdReceiverQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
