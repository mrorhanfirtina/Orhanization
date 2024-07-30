using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;

namespace Monstersoft.VennWms.Main.Application.Services.Abstract.CommonServices;

public interface IActionParameterService
{
    public List<ActionParameter> GetUserActionParameters(int userId, Guid depositorCompanyId, Guid? depositorId = null); //Kullanıcı için frontend tarafında kullanılacak parametreleri getirir.
}
