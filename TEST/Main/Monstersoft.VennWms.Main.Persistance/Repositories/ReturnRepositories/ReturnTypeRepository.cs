﻿using Monstersoft.VennWms.Main.Application.Repositories.ReturnRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;
using Monstersoft.VennWms.Main.Persistance.Contexts;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Persistance.Repositories.ReturnRepositories;

public class ReturnTypeRepository : EFRepositoryBase<ReturnType, Guid, BaseDbContext>, IReturnTypeRepository { public ReturnTypeRepository(BaseDbContext context) : base(context) { } }
