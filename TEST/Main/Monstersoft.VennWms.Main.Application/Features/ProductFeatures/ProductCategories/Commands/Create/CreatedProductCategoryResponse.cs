﻿using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategories.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategories.Commands.Create;

public class CreatedProductCategoryResponse
{
    public Guid Id { get; set; }
    public Guid ProductId { get; set; }
    public int CategoryId { get; set; }
    public DateTime CreatedDate { get; set; }
    public ProductCategoryProductCategoryListResponseDto? Category { get; set; }
    public ProductCategoryProductResponseDto? Product { get; set; }
}

