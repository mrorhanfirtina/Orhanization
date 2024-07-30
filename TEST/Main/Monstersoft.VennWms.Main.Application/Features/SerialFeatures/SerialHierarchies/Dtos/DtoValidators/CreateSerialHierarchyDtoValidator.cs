using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialHierarchies.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialHierarchies.Dtos.DtoValidators;

public class CreateSerialHierarchyDtoValidator : AbstractValidator<CreateSerialHierarchyDto>
{
    public CreateSerialHierarchyDtoValidator()
    {
        RuleFor(p => p.RootSerialId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.ChildSerialId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
