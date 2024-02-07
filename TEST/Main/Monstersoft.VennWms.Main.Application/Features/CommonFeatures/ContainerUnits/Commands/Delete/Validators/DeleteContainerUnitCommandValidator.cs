using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Commands.Delete.Validators;

public class DeleteContainerUnitCommandValidator : AbstractValidator<DeleteContainerUnitCommand>
{
    public DeleteContainerUnitCommandValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MinimumLength(2).MaximumLength(30);
        RuleFor(p => p.DepositorCode).NotEmpty().NotNull().MinimumLength(2);
    }
}
