using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;

public class UnitConversion : Entity<int>
{
    public int ReferenceUnitId { get; set; }
    public int TargetUnitId { get; set; }
    public decimal ConversionRate { get; set; }
    public Unit? TargetUnit { get; set; }
    public Unit? ReferenceUnit { get; set; }
    public UnitConversion()
    {
    }

    public UnitConversion(int id, int referenceUnitId, int targetUnitId, decimal conversionRate) : this()
    {
        Id = id;
        ReferenceUnitId = referenceUnitId;
        TargetUnitId = targetUnitId;
        ConversionRate = conversionRate;
    }

}
