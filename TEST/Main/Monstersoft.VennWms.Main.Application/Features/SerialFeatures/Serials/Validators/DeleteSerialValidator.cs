using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.Serials.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.Serials.Validators;

public class DeleteSerialValidator : AbstractValidator<DeleteSerialCommand>
{
    public DeleteSerialValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
