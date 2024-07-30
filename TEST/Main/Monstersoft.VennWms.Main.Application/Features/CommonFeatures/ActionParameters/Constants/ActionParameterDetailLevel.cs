namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameters.Constants;

public class ActionParameterDetailLevel
{
    public bool IncludeActionParameterCategory { get; set; } = false;


    public bool IncludeActionParameterUser { get; set; } = false;
    public ActionParameterParameterUserSubDetailLevel ActionParameterUserDetailLevel { get; set; } = new ActionParameterParameterUserSubDetailLevel();

    public class ActionParameterParameterUserSubDetailLevel
    {
        public bool IncludeUser { get; set; } = false;
    }


    public bool IncludeActionParameterDepositor { get; set; } = false;
    public ActionParameterParameterDepositorSubDetailLevel ActionParameterDepositorDetailLevel { get; set; } = new ActionParameterParameterDepositorSubDetailLevel();
    public class ActionParameterParameterDepositorSubDetailLevel
    {
        public bool IncludeDepositor { get; set; } = false;
        public ActionParameterParameterCompanySubDetailLevel ActionParameterCompanyDetailLevel { get; set; } = new ActionParameterParameterCompanySubDetailLevel();
        public class ActionParameterParameterCompanySubDetailLevel
        {
            public bool IncludeCompany { get; set; } = false;
        }
    }
}
