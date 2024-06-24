using Nest;
using Orhanization.Core.Persistence.Repositories;
using Orhanization.Core.Security.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Application.Repositories.AuthenticationRepositories;

public interface IEmailAuthenticatorRepository : IAsyncRepository<EmailAuthenticator , int>, IRepository<EmailAuthenticator, int> { }
