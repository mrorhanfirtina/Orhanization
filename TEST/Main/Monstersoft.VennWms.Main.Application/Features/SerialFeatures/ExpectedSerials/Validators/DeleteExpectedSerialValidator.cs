using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerials.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerials.Validators;

public class DeleteExpectedSerialValidator : AbstractValidator<DeleteExpectedSerialCommand>
{
    public DeleteExpectedSerialValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
