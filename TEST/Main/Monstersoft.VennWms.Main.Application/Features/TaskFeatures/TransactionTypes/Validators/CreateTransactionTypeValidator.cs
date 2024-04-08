using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.WorkTaskDtos;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TransactionTypes.Commands.Create;

namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TransactionTypes.Validators;

public class CreateTransactionTypeValidator : AbstractValidator<CreateTransactionTypeCommand>
{
    public CreateTransactionTypeValidator()
    {
        RuleFor(x => x.TransactionType).SetValidator(new CreateTransactionTypeDtoValidator());
    }
}
