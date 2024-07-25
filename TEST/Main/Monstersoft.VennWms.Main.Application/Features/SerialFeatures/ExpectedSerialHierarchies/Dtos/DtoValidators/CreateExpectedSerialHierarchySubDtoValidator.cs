﻿using FluentValidation;
using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerialHierarchies.Dtos.CreateDtos;

namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerialHierarchies.Dtos.DtoValidators;

public class CreateExpectedSerialHierarchySubDtoValidator : AbstractValidator<CreateExpectedSerialHierarchySubDto>
{
    public CreateExpectedSerialHierarchySubDtoValidator()
    {
        RuleFor(p => p.RootSerialId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
        RuleFor(p => p.ChildSerialId).NotEmpty().NotEqual(Guid.Empty).WithMessage("{PropertyName} alanı boş Guid olamaz.");
    }
}