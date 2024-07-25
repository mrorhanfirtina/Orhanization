using Orhanization.Core.Security.Entities;
using Orhanization.Core.Security.JWT;

namespace Monstersoft.VennWms.Main.Application.Services.Abstract.AuthenticationServices;

public interface IAuthService
{
    public Task<AccessToken> CreateAccessToken(User user);
    public Task<RefreshToken> CreateRefreshToken(User user, string ipAddress);
    public Task<RefreshToken?> GetRefreshTokenByToken(string token);
    public Task<RefreshToken> AddRefreshToken(RefreshToken refreshToken);
    public Task DeleteOldRefreshTokens(int userId);
    public Task RevokeDescendantRefreshTokens(RefreshToken refreshToken, string ipAddress, string reason);
    public Task RevokeRefreshToken(RefreshToken token, string ipAddress, string? reason = null, string? replacedByToken = null);
    public Task<RefreshToken> RotateRefreshToken(User user, RefreshToken refreshToken, string ipAddress);
}
