using Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderMemos.Dtos.ResponseDtos;

namespace Monstersoft.VennWms.Main.Application.Features.OrderFeatures.OrderMemos.Queries.GetListByDynamic;

public class GetListByDynamicOrderMemoListItemDto
{
    public Guid Id { get; set; }
    public Guid OrderId { get; set; }
    public string Description { get; set; }
    public string Text { get; set; }
    public DateTime InputDate { get; set; }
    public DateTime EditDate { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime UpdatedDate { get; set; }
    public OrderMemoOrderResponseDto? Order { get; set; }
}

