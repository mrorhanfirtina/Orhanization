﻿using Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItemMemos.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.ReturnFeatures.ReturnItemMemos.Commands.Create;

public class CreatedReturnItemMemoResponse
{
    public Guid Id { get; set; }
    public Guid ReturnItemId { get; set; }
    public string Description { get; set; }
    public string Text { get; set; }
    public DateTime InputDate { get; set; }
    public DateTime? EditDate { get; set; }
    public DateTime CreatedDate { get; set; }
    public ReturnItemMemosReturnItemResponseDto? ReturnItem { get; set; }
}

