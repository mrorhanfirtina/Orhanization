using Monstersoft.VennWms.Main.Application.Repositories.AuthenticationRepositories;
using Monstersoft.VennWms.Main.Persistance.Contexts;
using Orhanization.Core.Persistence.Repositories;
using Orhanization.Core.Security.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Persistance.Repositories.AuthenticationRepositories;

public class UserRepository : EFRepositoryBase<User, int, BaseDbContext>, IUserRepository
{
    public UserRepository(BaseDbContext context)
        : base(context) { }
}
