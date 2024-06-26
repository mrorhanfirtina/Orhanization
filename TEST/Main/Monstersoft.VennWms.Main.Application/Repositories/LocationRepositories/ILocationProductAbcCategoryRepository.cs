﻿using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Application.Repositories.LocationRepositories;

public interface ILocationProductAbcCategoryRepository : IAsyncRepository<LocationProductAbcCategory, Guid>, IRepository<LocationProductAbcCategory, Guid> { }

