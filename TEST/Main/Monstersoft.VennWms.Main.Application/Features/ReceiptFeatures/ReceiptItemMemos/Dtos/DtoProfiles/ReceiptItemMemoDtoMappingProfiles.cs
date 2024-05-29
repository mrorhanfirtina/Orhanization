﻿using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItemMemos.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItemMemos.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;

namespace Monstersoft.VennWms.Main.Application.Features.ReceiptFeatures.ReceiptItemMemos.Dtos.DtoProfiles;

public class ReceiptItemMemoDtoMappingProfiles : Profile
{
    public ReceiptItemMemoDtoMappingProfiles()
    {
        CreateMap<ReceiptItemMemo, CreateReceiptItemMemoDto>().ReverseMap();
        CreateMap<ReceiptItemMemo, CreateReceiptItemMemoSubDto>().ReverseMap();
        CreateMap<ReceiptItemMemo, UpdateReceiptItemMemoDto>().ReverseMap();
        CreateMap<ReceiptItemMemo, UpdateReceiptItemMemoSubDto>().ReverseMap();
    }
}