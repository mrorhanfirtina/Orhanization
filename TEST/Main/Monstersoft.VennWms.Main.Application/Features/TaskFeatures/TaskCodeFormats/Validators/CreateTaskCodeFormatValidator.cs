using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.WorkTaskDtos;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskCodeFormats.Commands.Create;

namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskCodeFormats.Validators;

public class CreateTaskCodeFormatValidator : AbstractValidator<CreateTaskCodeFormatCommand>
{
    public CreateTaskCodeFormatValidator()
    {
        RuleFor(x => x.TaskCodeFormat).SetValidator(new CreateTaskCodeFormatDtoValidator());
    }
}
