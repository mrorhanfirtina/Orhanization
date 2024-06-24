using Orhanization.Core.Security.Entities;

namespace Monstersoft.VennWms.Main.Application.Services.Abstract.AuthenticationServices;

public interface IUserService
{
    public Task<User?> GetByEmail(string email);
    public Task<User> GetById(int id);
    public Task<User> Update(User user);
}

