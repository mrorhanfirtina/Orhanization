using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.PriorityLists.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.PriorityLists.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.PriorityLists.Validators;

public class UpdatePriorityListValidator : AbstractValidator<UpdatePriorityListCommand>
{
    public UpdatePriorityListValidator()
    {
        RuleFor(x => x.PriorityList).SetValidator(new UpdatePriorityListDtoValidator());
    }
}



