using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialLogs.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialLogs.Validators;

public class DeleteSerialLogValidator : AbstractValidator<DeleteSerialLogCommand>
{
    public DeleteSerialLogValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
