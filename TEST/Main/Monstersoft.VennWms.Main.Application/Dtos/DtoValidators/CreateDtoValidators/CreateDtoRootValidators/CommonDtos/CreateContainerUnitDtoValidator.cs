using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.CreateCommandDtos.RootDtos.CommonDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.CreateDtoValidators.CreateDtoRootValidators.CommonDtos;

public class CreateContainerUnitDtoValidator : AbstractValidator<CreateContainerUnitDto>
{
    public CreateContainerUnitDtoValidator()
    {
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
        RuleFor(p => p.Description).NotEmpty().NotNull().MaximumLength(60);

        RuleFor(p => p.FirstDigit)
            .NotEmpty().NotNull().MaximumLength(1)
            .Matches("^[1-9]$").WithMessage("{PropertyName} sadece rakamlardan oluşmalı ve 0 ile başlayamaz.");

        RuleFor(p => p.CountryCode)
            .NotEmpty().NotNull().MaximumLength(3)
            .Matches("^[1-9][0-9]*$").WithMessage("{PropertyName} sadece rakamlardan oluşmalı ve 0 ile başlayamaz.");

        RuleFor(p => p.ProducerCode)
            .NotEmpty().NotNull().MaximumLength(7)
            .Matches("^[1-9][0-9]*$").WithMessage("{PropertyName} sadece rakamlardan oluşmalı ve 0 ile başlayamaz.");

        RuleFor(p => p.Counter)
            .NotEmpty().NotNull().MaximumLength(7)
            .Matches("^[1-9][0-9]*$").WithMessage("{PropertyName} sadece rakamlardan oluşmalı ve 0 ile başlayamaz.");
    }
}



