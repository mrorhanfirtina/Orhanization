namespace Orhanization.Core.Persistence.Dynamic.Aggregate;

public class Having
{
    // Field: Agg alias’ı ("OrderCount") veya fonksiyon ("Sum(TotalQty)")
    public string Field { get; set; } = string.Empty;
    public string Op { get; set; } = "gte";   // eq, neq, gt, gte, lt, lte
    public string? Value { get; set; }
}
