using Monstersoft.VennWms.Main.Application.Repositories.BarcodeRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.BarcodeEntities;
using Monstersoft.VennWms.Main.Persistance.Contexts;
using Orhanization.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Persistance.Repositories.BarcodeRepositories;

public class BarcodeRepository : EFRepositoryBase<Barcode, Guid, BaseDbContext>, IBarcodeRepository { public BarcodeRepository(BaseDbContext context) : base(context) { } }

