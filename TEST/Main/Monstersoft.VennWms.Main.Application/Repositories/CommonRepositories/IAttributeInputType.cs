using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Orhanization.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;

public interface IAttributeInputTypeRepository : IAsyncRepository<AttributeInputType, int>, IRepository<AttributeInputType, int> { }


