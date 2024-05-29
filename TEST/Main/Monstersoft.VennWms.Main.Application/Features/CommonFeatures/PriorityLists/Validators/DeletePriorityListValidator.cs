using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.PriorityLists.Commands.Delete;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.PriorityLists.Validators;

public class DeletePriorityListValidator : AbstractValidator<DeletePriorityListCommand>
{
    public DeletePriorityListValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotNull().InclusiveBetween(1, int.MaxValue);
    }
}



