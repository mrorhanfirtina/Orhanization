using FluentValidation;
using Monstersoft.VennWms.Main.Application.Dtos.UpdateCommandDtos.SubDtos.ProductDtos;

namespace Monstersoft.VennWms.Main.Application.Dtos.DtoValidators.UpdateDtoValidators.UpdateSubDtoValidators.ProductDtos;

public class UpdateItemPackTypeSubDtoValidator : AbstractValidator<UpdateItemPackTypeSubDto>
{
    public UpdateItemPackTypeSubDtoValidator()
    {
        RuleFor(p => p.ItemUnitId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.Length).PrecisionScale(18, 6, false).WithMessage("{PropertyName} alanında decimal değeri için doğru aralıkta değer girilmeli.");
        RuleFor(p => p.Width).PrecisionScale(18, 6, false).WithMessage("{PropertyName} alanında decimal değeri için doğru aralıkta değer girilmeli.");
        RuleFor(p => p.Height).PrecisionScale(18, 6, false).WithMessage("{PropertyName} alanında decimal değeri için doğru aralıkta değer girilmeli.");
        RuleFor(p => p.LenghtUnitId).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
        RuleFor(p => p.Volume).PrecisionScale(18, 6, false).WithMessage("{PropertyName} alanında decimal değeri için doğru aralıkta değer girilmeli.");
        RuleFor(p => p.VolumeUnitId).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
        RuleFor(p => p.DeadWeight).PrecisionScale(18, 6, false).WithMessage("{PropertyName} alanında decimal değeri için doğru aralıkta değer girilmeli.");
        RuleFor(p => p.NetWeight).PrecisionScale(18, 6, false).WithMessage("{PropertyName} alanında decimal değeri için doğru aralıkta değer girilmeli.");
        RuleFor(p => p.WeightUnitId).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);

    }
}


