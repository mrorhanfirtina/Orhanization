using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerialHierarchies.Dtos.UpdateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerialHierarchies.Dtos.DtoValidators;

public class UpdateExpectedSerialHierarchySubDtoValidator : AbstractValidator<UpdateExpectedSerialHierarchySubDto>
{
    public UpdateExpectedSerialHierarchySubDtoValidator()
    {
        RuleFor(p => p.RootSerialId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.ChildSerialId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}
