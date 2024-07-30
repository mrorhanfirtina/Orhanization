using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialHierarchies.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.SerialHierarchies.Dtos.DtoValidators;

public class UpdateSerialHierarchySubDtoValidator : AbstractValidator<UpdateSerialHierarchySubDto>
{
    public UpdateSerialHierarchySubDtoValidator()
    {
        RuleFor(p => p.ChildSerialId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
