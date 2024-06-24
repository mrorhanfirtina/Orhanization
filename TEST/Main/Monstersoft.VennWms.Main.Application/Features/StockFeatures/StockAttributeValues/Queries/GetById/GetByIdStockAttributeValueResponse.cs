﻿using Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributeValues.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.StockFeatures.StockAttributeValues.Queries.GetById;

public class GetByIdStockAttributeValueResponse
{
    public Guid Id { get; set; }
    public Guid StockId { get; set; }
    public Guid StockAttributeId { get; set; }
    public string Value { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public StockAttributeValuesStockAttributeResponseDto? StockAttribute { get; set; }
    public StockAttributeValuesStockResponseDto? Stock { get; set; }
}

