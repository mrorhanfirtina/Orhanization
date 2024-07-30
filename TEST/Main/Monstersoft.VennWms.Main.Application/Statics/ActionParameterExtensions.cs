using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Orhanization.Core.Persistence.Paging;

namespace Monstersoft.VennWms.Main.Application.Statics;

public static class ActionParameterExtensions
{
    public static List<ActionParameter> GetActionParameters(this IActionParameterRepository _actionParameterRepository,int userId, Guid depositorCompanyId, Guid? depositorId = null)
    {
        Paginate<ActionParameter> actionParameter = _actionParameterRepository.GetList(index: 0, size: 10000);

        Paginate<ActionParameter> actionParameterUser = _actionParameterRepository.GetList(
            index: 0, size: 10000,
            include: x => x.Include(p => p.ActionParameterUsers),
            predicate: x => x.ActionParameterUsers.Any(y => y.UserId == userId));

        if (actionParameterUser.Items.Count > 0)
        {
            actionParameter.Items?.ToList().ForEach(x => {
                x.ActionParameterUsers.ToList().ForEach(y =>
                {
                    if (y.ActionParameterId == x.Id)
                    {
                        x.DefaultValue = y.Value;
                    }
                });
            });

            return actionParameter.Items?.ToList();
        }


        if (depositorId != null)
        {
            Paginate<ActionParameter> actionParameterDepositor = _actionParameterRepository.GetList(
                        index: 0, size: 10000,
                        include: x => x.Include(p => p.ActionParameterDepositors),
                        predicate: x => x.ActionParameterDepositors.Any(y => y.DepositorId == depositorId));

            if (actionParameterDepositor.Items.Count > 0)
            {
                actionParameter.Items?.ToList().ForEach(x => {
                    x.ActionParameterDepositors.ToList().ForEach(y =>
                    {
                        if (y.ActionParameterId == x.Id)
                        {
                            x.DefaultValue = y.Value;
                        }
                    });
                });

                return actionParameter.Items?.ToList();
            }
        }


        Paginate<ActionParameter> actionParameterDefault = _actionParameterRepository.GetList(
            index: 0, size: 10000,
            include: x => x.Include(p => p.ActionParameterDefaults),
            predicate: x => x.ActionParameterDefaults.Any(y => y.DepositorCompanyId == depositorCompanyId));

        if (actionParameterDefault.Items.Count > 0)
        {
            if (actionParameterDefault.Items.Count > 0)
            {
                actionParameter.Items?.ToList().ForEach(x => {
                    x.ActionParameterDefaults.ToList().ForEach(y =>
                    {
                        if (y.ActionParameterId == x.Id)
                        {
                            x.DefaultValue = y.Value;
                        }
                    });
                });

                return actionParameter.Items?.ToList();
            }
        }

        return actionParameter.Items?.ToList();
    }
}
