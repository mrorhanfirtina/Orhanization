using FluentValidation;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDefaults;

public class DeleteActionParameterDefaultValidator : AbstractValidator<DeleteActionParameterDefaultCommand>
{
    public DeleteActionParameterDefaultValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
