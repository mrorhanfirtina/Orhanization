using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.PriorityLists.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.PriorityLists.Dtos.DtoValidators;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.PriorityLists.Validators;

public class CreatePriorityListValidator : AbstractValidator<CreatePriorityListCommand>
{
    public CreatePriorityListValidator()
    {
        RuleFor(x => x.PriorityList).SetValidator(new CreatePriorityListDtoValidator());
    }
}



