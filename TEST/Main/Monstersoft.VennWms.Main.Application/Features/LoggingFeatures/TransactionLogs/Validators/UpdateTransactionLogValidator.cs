using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.LoggingDtos;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.TransactionLogs.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.TransactionLogs.Validators;

public class UpdateTransactionLogValidator : AbstractValidator<UpdateTransactionLogCommand>
{
    public UpdateTransactionLogValidator()
    {
        RuleFor(x => x.TransactionLog).SetValidator(new UpdateTransactionLogDtoValidator());
    }
}
