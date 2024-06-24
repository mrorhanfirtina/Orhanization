using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStocks.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.LogStocks.Validators;

public class DeleteLogStockValidator : AbstractValidator<DeleteLogStockCommand>
{
    public DeleteLogStockValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
