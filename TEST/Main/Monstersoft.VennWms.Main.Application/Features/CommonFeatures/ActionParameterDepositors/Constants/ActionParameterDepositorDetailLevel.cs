namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDepositors.Constants;

public class ActionParameterDepositorDetailLevel
{
    public bool IncludeActionParameter { get; set; } = false;
    public ActionParameterDepositorParameterSubDetailLevel ActionParameterDepositorParameterDetailLevel { get; set; } = new ActionParameterDepositorParameterSubDetailLevel();
    public class ActionParameterDepositorParameterSubDetailLevel
    {
        public bool IncludeCategory { get; set; } = false;
    }


    public bool IncludeDepositor { get; set; } = false;
    public ActionParameterDepositorDepositorSubDetailLevel ActionParameterDepositorDepositorDetailLevel { get; set; } = new ActionParameterDepositorDepositorSubDetailLevel();
    public class ActionParameterDepositorDepositorSubDetailLevel
    {
        public bool IncludeCompany { get; set; } = false;
    }
}
