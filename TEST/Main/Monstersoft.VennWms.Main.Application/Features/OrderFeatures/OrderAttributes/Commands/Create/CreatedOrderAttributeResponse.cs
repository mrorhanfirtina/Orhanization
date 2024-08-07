﻿using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributes.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderAttributes.Commands.Create;

public class CreatedOrderAttributeResponse
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public int AttributeInputTypeId { get; set; }
    public bool IsNecessary { get; set; }
    public bool IsItemAttribte { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public DateTime CreatedDate { get; set; }
    public OrderAttributeAttributeInputTypeResponseDto? AttributeInputType { get; set; }
    public OrderAttributeDepositorCompanyResponseDto? DepositorCompany { get; set; }

}

