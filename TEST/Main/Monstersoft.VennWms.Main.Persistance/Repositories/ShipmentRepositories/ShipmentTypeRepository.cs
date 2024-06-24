﻿using Monstersoft.VennWms.Main.Application.Repositories.ShipmentRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.ShipmentEntities;
using Monstersoft.VennWms.Main.Persistance.Contexts;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Persistance.Repositories.ShipmentRepositories;

public class ShipmentTypeRepository : EFRepositoryBase<ShipmentType, Guid, BaseDbContext>, IShipmentTypeRepository { public ShipmentTypeRepository(BaseDbContext context) : base(context) { } }
