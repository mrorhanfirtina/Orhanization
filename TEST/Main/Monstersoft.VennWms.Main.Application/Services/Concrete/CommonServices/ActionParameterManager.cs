using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Application.Services.Abstract.CommonServices;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;

namespace Monstersoft.VennWms.Main.Application.Services.Concrete.CommonServices;

public class ActionParameterManager : IActionParameterService
{
    private readonly IActionParameterRepository _actionParameterRepository;

    public ActionParameterManager(IActionParameterRepository actionParameterRepository)
    {
        _actionParameterRepository = actionParameterRepository;
    }
    public List<ActionParameter> GetUserActionParameters(int userId, Guid depositorCompanyId, Guid? depositorId = null)
    {
        return _actionParameterRepository.GetActionParameters(userId, depositorCompanyId, depositorId);
    }
}
