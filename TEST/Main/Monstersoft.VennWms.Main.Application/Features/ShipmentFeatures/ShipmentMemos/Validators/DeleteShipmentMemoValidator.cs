using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentMemos.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.ShipmentFeatures.ShipmentMemos.Validators;

public class DeleteShipmentMemoValidator : AbstractValidator<DeleteShipmentMemoCommand>
{
    public DeleteShipmentMemoValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
