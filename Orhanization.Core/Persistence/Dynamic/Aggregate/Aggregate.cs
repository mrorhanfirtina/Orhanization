namespace Orhanization.Core.Persistence.Dynamic.Aggregate;

public class Aggregate
{
    // type: count|sum|avg|min|max
    public string Type { get; set; } = string.Empty;
    public string As { get; set; } = string.Empty;
    public string? Field { get; set; } // count hariç zorunlu
}
