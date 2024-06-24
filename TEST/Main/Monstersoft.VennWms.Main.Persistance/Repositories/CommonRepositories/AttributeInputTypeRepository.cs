using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Persistance.Contexts;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Persistance.Repositories.CommonRepositories;

public class AttributeInputTypeRepository : EFRepositoryBase<AttributeInputType, int, BaseDbContext>, IAttributeInputTypeRepository { public AttributeInputTypeRepository(BaseDbContext context) : base(context) { } }
