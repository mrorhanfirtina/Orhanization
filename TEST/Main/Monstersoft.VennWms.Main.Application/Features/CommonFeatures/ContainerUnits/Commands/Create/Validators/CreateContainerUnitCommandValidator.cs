using FluentValidation;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Commands.Create.Validators;

public class CreateContainerUnitCommandValidator : AbstractValidator<CreateContainerUnitCommand>
{
   public CreateContainerUnitCommandValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MinimumLength(2).MaximumLength(30);
        RuleFor(p => p.Description).NotEmpty().NotNull().MaximumLength(60);
        RuleFor(p => p.FirstDigit).NotEmpty().NotNull().MaximumLength(1);
        RuleFor(p => p.CountryCode).NotEmpty().NotNull().MaximumLength(2);
        RuleFor(p => p.ProducerCode).NotEmpty().NotNull().MaximumLength(7);
        RuleFor(p => p.Counter).NotEmpty().NotNull().MaximumLength(7);
        RuleFor(p => p.DepositorCode).NotEmpty().NotNull().MinimumLength(2);

        RuleFor(p => p.Counter).Must(value => value.ToString()[0] != '0').WithMessage("{PropertyName} 0 ile başlayamaz.");
        RuleFor(p => p.Counter).Matches(@"^\d+$").WithMessage("{PropertyName} sadece rakamlardan oluşmalıdır.");

        RuleFor(p => p.CountryCode).Must(value => value.ToString()[0] != '0').WithMessage("{PropertyName} 0 ile başlayamaz.");
        RuleFor(p => p.CountryCode).Matches(@"^\d+$").WithMessage("{PropertyName} sadece rakamlardan oluşmalıdır.");

        RuleFor(p => p.ProducerCode).Must(value => value.ToString()[0] != '0').WithMessage("{PropertyName} 0 ile başlayamaz.");
        RuleFor(p => p.ProducerCode).Matches(@"^\d+$").WithMessage("{PropertyName} sadece rakamlardan oluşmalıdır.");

        RuleFor(p => p.FirstDigit).Must(value => value.ToString()[0] != '0').WithMessage("{PropertyName} 0 olamaz.");
        RuleFor(p => p.FirstDigit).Matches(@"^\d+$").WithMessage("{PropertyName} sadece rakamlardan oluşmalıdır.");

        //RuleFor(p => p.FirstDigit).Matches(@"^[a-zA-Z0-9]+$").WithMessage("{PropertyName} alfanumerik deger olmalıdır.");
    }
}
