using Orhanization.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Orhanization.Core.Security.Entities;

public class OtpAuthenticator : Entity<int>
{
    public int UserId { get; set; }
    public byte[] SecretKey { get; set; }
    public bool IsVerified { get; set; }
    [JsonIgnore]
    public virtual User User { get; set; } = null!;

    public OtpAuthenticator()
    {
        SecretKey = Array.Empty<byte>();
    }

    public OtpAuthenticator(int userId, byte[] secretKey, bool isVerified)
    {
        UserId = userId;
        SecretKey = secretKey;
        IsVerified = isVerified;
    }

    public OtpAuthenticator(int id, int userId, byte[] secretKey, bool isVerified)
        : base(id)
    {
        UserId = userId;
        SecretKey = secretKey;
        IsVerified = isVerified;
    }
}
