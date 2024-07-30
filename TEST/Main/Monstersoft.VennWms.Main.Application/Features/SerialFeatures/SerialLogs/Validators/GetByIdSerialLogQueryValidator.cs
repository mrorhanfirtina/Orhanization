using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialLogs.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialLogs.Validators;

public class GetByIdSerialLogQueryValidator : AbstractValidator<GetByIdSerialLogQuery>
{
    public GetByIdSerialLogQueryValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
