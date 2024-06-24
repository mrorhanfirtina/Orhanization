using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributes.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.POFeatures.PoAttributes.Dtos.DtoValidators;

public class UpdatePoAttributeDtoValidator : AbstractValidator<UpdatePoAttributeDto>
{
    public UpdatePoAttributeDtoValidator()
    {
        RuleFor(p => p.Id).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.Code).NotEmpty().NotNull().MaximumLength(30);
        RuleFor(p => p.Description).NotEmpty().NotNull().MaximumLength(60);
        RuleFor(p => p.AttributeInputTypeId).NotEmpty().NotNull().InclusiveBetween(0, int.MaxValue);
        RuleFor(p => p.IsNecessary).NotNull().WithMessage("{PropertyName} alanı sadece true veya false değeri alabilir.");
    }
}



