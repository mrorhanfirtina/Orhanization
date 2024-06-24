using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Orhanization.Core.Persistence.Repositories;
using Monstersoft.VennWms.Main.Domain.Entities.BarcodeEntities;

namespace Monstersoft.VennWms.Main.Application.Repositories.BarcodeRepositories;

public interface IBarcodeRepository : IAsyncRepository<Barcode, Guid>, IRepository<Barcode, Guid> { }
