namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Units.Constants;

public class UnitDetailLevel
{
    public bool IncludeDepositorCompany { get; set; } = false;
    public bool IncludeReferenceUnit { get; set; } = false;

    public UnitReferenceUnitDetailLevel ReferenceUnitDetailLevel { get; set; } = new UnitReferenceUnitDetailLevel();

    public class UnitReferenceUnitDetailLevel
    {
        public bool IncludeTargetUnit { get; set; } = false;
    }
}
