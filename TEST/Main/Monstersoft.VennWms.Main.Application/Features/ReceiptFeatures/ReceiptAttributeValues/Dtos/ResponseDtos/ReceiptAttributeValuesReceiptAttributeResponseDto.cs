﻿namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptAttributeValues.Dtos.ResponseDtos;

public class ReceiptAttributeValuesReceiptAttributeResponseDto
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public int AttributeInputTypeId { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public bool IsNecessary { get; set; }
    public ReceiptAttributeValuesAttributeInputTypeResponseDto? AttributeInputType { get; set; }
}