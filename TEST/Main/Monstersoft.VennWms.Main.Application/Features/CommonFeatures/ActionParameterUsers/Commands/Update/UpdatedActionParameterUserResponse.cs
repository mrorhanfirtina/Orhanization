﻿using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterUsers.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterUsers.Commands.Update;

public class UpdatedActionParameterUserResponse
{
    public Guid Id { get; set; }
    public int ActionParameterId { get; set; }
    public int UserId { get; set; }
    public string Value { get; set; }
    public ActionParameterUserParameterResponseDto? ActionParameter { get; set; }
    public ActionParameterUserUserResponseDto? User { get; set; }
}