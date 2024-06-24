namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.Units.Constants;

public class UnitsDetailLevel
{
    public bool IncludeDepositorCompany { get; set; } = false;
    public bool IncludeReferenceUnit { get; set; } = false;

    public UnitsReferenceUnitSubDetailLevel ReferenceUnitDetailLevel { get; set; } = new UnitsReferenceUnitSubDetailLevel();

    public class UnitsReferenceUnitSubDetailLevel
    {
        public bool IncludeTargetUnit { get; set; } = false;
    }
}
