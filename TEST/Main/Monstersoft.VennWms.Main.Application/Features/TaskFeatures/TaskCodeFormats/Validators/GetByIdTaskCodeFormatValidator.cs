using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskCodeFormats.Queries.GetById;

namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskCodeFormats.Validators;

public class GetByIdTaskCodeFormatValidator : AbstractValidator<GetByIdTaskCodeFormatQuery>
{
    public GetByIdTaskCodeFormatValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
