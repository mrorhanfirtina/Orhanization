﻿namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderMemos.Commands.Create;

public class CreatedOrderMemoResponse
{
    public Guid Id { get; set; }
    public Guid OrderId { get; set; }
    public string Description { get; set; }
    public string Text { get; set; }
    public DateTime InputDate { get; set; }
    public DateTime EditDate { get; set; }
    public DateTime CreatedDate { get; set; }

}
