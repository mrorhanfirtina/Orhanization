using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Addresses.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Addresses.Dtos.DtoValidators;

public class UpdateAddressSubDtoValidator : AbstractValidator<UpdateAddressSubDto>
{
    public UpdateAddressSubDtoValidator()
    {
        RuleFor(p => p.Description).NotEmpty().NotNull().MaximumLength(120);
        RuleFor(p => p.Province).NotEmpty().NotNull().MaximumLength(60);
        RuleFor(p => p.City).NotEmpty().NotNull().MaximumLength(60);
        RuleFor(p => p.Country).NotEmpty().NotNull().MaximumLength(60);
        RuleFor(p => p.AddressText).NotEmpty().NotNull().MaximumLength(250);
        RuleFor(p => p.ZipCode).NotEmpty().NotNull().MaximumLength(10);
        RuleFor(p => p.Longitude).PrecisionScale(11, 7, false).WithMessage("{PropertyName} alanında decimal değeri için doğru aralıkta değer girilmeli.");
        RuleFor(p => p.Latitude).PrecisionScale(11, 7, false).WithMessage("{PropertyName} alanında decimal değeri için doğru aralıkta değer girilmeli.");
    }
}


