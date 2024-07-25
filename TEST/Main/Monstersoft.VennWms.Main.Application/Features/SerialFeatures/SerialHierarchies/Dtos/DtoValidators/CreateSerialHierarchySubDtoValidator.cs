using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialHierarchies.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialHierarchies.Dtos.DtoValidators;

public class CreateSerialHierarchySubDtoValidator : AbstractValidator<CreateSerialHierarchySubDto>
{
    public CreateSerialHierarchySubDtoValidator()
    {
        RuleFor(p => p.ChildSerialId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
