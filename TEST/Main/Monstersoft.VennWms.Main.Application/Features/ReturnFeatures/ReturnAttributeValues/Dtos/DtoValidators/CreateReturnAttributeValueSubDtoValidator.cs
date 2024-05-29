using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributeValues.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnAttributeValues.Dtos.DtoValidators;

public class CreateReturnAttributeValueSubDtoValidator : AbstractValidator<CreateReturnAttributeValueSubDto>
{
    public CreateReturnAttributeValueSubDtoValidator()
    {
        RuleFor(p => p.ReturnAttributeId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.Value).NotEmpty().NotNull().MaximumLength(120);
    }
}


