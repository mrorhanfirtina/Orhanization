namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterUsers.Constants;

public class ActionParameterUserDetailLevel
{
    public bool IncludeUser { get; set; } = false;
    public bool IncludeActionParameter { get; set; } = false;
    public ActionParameterUserParameterSubDetailLevel ActionParameterUserParameterDetailLevel { get; set; } = new ActionParameterUserParameterSubDetailLevel();
    public class ActionParameterUserParameterSubDetailLevel
    {
        public bool IncludeCategory { get; set; } = false;
    }
}