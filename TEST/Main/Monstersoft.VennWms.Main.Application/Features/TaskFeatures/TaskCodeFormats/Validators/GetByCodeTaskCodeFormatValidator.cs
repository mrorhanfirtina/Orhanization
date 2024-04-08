using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskCodeFormats.Queries.GetByCode;

namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskCodeFormats.Validators;

public class GetByCodeTaskCodeFormatValidator : AbstractValidator<GetByCodeTaskCodeFormatQuery>
{
    public GetByCodeTaskCodeFormatValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(6);
    }
}
