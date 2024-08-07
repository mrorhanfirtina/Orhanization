﻿using Monstersoft.VennWms.Main.Domain.Entities.LocationEntities;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Application.Repositories.LocationRepositories;

public interface ILocationUnitConstraintRepository : IAsyncRepository<LocationUnitConstraint, Guid>, IRepository<LocationUnitConstraint, Guid> { }
