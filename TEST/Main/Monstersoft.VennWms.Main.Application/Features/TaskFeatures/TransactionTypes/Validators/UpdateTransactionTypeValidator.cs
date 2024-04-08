using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateDtoRootValidators.WorkTaskDtos;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TransactionTypes.Commands.Update;

namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TransactionTypes.Validators;

public class UpdateTransactionTypeValidator : AbstractValidator<UpdateTransactionTypeCommand>
{
    public UpdateTransactionTypeValidator()
    {
        RuleFor(x => x.TransactionType).SetValidator(new UpdateTransactionTypeDtoValidator());
    }
}
