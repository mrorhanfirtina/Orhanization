﻿using Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerialHierarchies.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.SerialFeatures.ExpectedSerialHierarchies.Queries.GetById;

public class GetByIdExpectedSerialHierarchyResponse
{
    public Guid Id { get; set; }
    public Guid RootSerialId { get; set; }
    public Guid ChildSerialId { get; set; }
    public ExpectedSerialHierarchyRootSerialResponseDto? RootSerial { get; set; }
    public ExpectedSerialHierarchyChildSerialResponseDto? ChildSerial { get; set; }
}