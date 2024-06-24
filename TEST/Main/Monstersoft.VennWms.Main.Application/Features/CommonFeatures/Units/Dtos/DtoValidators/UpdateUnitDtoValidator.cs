using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnitConversions.Dtos.DtoValidators;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Units.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Units.Dtos.DtoValidators;

public class UpdateUnitDtoValidator : AbstractValidator<UpdateUnitDto>
{
    public UpdateUnitDtoValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
        RuleFor(p => p.Description).NotEmpty().NotNull().MaximumLength(60);
        RuleForEach(p => p.ReferenceUnitConversions).SetValidator(new UpdateUnitConversionSubDtoValidator());
    }
}



