using Orhanization.Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Orhanization.Core.Security.Entities;

public class UserOperationClaim : Entity<int>
{
    public int UserId { get; set; }
    public int OperationClaimId { get; set; }
    [JsonIgnore]
    public virtual User User { get; set; } = null!;
    [JsonIgnore]
    public virtual OperationClaim OperationClaim { get; set; } = null!;

    public UserOperationClaim(int userId, int operationClaimId)
    {
        UserId = userId;
        OperationClaimId = operationClaimId;
    }

    public UserOperationClaim(int id, int userId, int operationClaimId)
        : base(id)
    {
        UserId = userId;
        OperationClaimId = operationClaimId;
    }
}
