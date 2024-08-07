﻿using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Application.Repositories.ReturnRepositories;

public interface IReturnAttributeValueRepository : IAsyncRepository<ReturnAttributeValue, Guid>, IRepository<ReturnAttributeValue, Guid> { }

