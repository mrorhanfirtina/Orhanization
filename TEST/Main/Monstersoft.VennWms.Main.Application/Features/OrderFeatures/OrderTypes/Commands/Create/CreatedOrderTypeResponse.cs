﻿using Monstersoft.VennWms.Main.Domain.Entities.OrderEntities;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderTypes.Commands.Create;

public class CreatedOrderTypeResponse
{
    public Guid Id { get; set; }
    public string Code { get; set; }
    public string Description { get; set; }
    public bool IsCodeGenerate { get; set; }
    public string Format { get; set; }
    public Guid DepositorCompanyId { get; set; }
    public int Counter { get; set; }
    public DateTime CreatedDate { get; set; }
    public ICollection<Order> Orders { get; set; }
}