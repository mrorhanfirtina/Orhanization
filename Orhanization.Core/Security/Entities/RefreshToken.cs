using Orhanization.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Orhanization.Core.Security.Entities;

public class RefreshToken : Entity<int>
{
    public int UserId { get; set; }
    public string Token { get; set; }
    public DateTime Expires { get; set; }
    public DateTime Created { get; set; }
    public string CreatedByIp { get; set; }
    public DateTime? Revoked { get; set; }
    public string? RevokedByIp { get; set; }
    public string? ReplacedByToken { get; set; }

    public string? ReasonRevoked { get; set; }
    [JsonIgnore]
    public virtual User User { get; set; } = null!;

    public RefreshToken()
    {
        Token = string.Empty;
        CreatedByIp = string.Empty;
    }

    public RefreshToken(int userId, string token, DateTime expires, string createdByIp, DateTime created)
    {
        UserId = userId;
        Token = token;
        Expires = expires;
        CreatedByIp = createdByIp;
        Created = created;
    }

    public RefreshToken(int id, int userId, string token, DateTime expires, string createdByIp, DateTime created)
        : base(id)
    {
        UserId = userId;
        Token = token;
        Expires = expires;
        CreatedByIp = createdByIp;
        Created = created;
    }
}
