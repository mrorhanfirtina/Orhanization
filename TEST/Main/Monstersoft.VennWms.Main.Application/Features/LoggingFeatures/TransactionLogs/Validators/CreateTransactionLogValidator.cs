using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.LoggingDtos;
using Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.TransactionLogs.Commands.Create;

namespace Monstersoft.VennWms.Main.Application.Features.LoggingFeatures.TransactionLogs.Validators;

public class CreateTransactionLogValidator : AbstractValidator<CreateTransactionLogCommand>
{
    public CreateTransactionLogValidator()
    {
        RuleFor(x => x.TransactionLog).SetValidator(new CreateTransactionLogDtoValidator());
    }
}
