namespace Orhanization.Core.Persistence.Dynamic.Aggregate;

public class AggregateQuery
{
    public DynamicQuery? Base { get; set; } // mevcut Filter + Sort burada
    public IEnumerable<string>? GroupBy { get; set; }          // ["Customer.Name","DepositorCode"]
    public IEnumerable<Aggregate>? Aggregates { get; set; }    // [{ "type":"count","as":"OrderCount" }, { "type":"sum","field":"TotalQty","as":"TotalQty" }]
    public IEnumerable<Having>? Having { get; set; }           // [{ "field":"OrderCount","op":"gte","value":"10" }]
    public IEnumerable<string>? Select { get; set; }           // gruplama yoksa projeksiyon
    public int? Limit { get; set; }                            // ≤ 500
}
