﻿using Monstersoft.VennWms.Main.Application.Repositories.LoggingRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.LoggingEntities;
using Monstersoft.VennWms.Main.Persistance.Contexts;
using Orhanization.Core.Persistence.Repositories;

namespace Monstersoft.VennWms.Main.Persistance.Repositories.LoggingRepositories;

public class TransactionLogRepository : EFRepositoryBase<TransactionLog, Guid, BaseDbContext>, ITransactionLogRepository { public TransactionLogRepository(BaseDbContext context) : base(context) { } }
