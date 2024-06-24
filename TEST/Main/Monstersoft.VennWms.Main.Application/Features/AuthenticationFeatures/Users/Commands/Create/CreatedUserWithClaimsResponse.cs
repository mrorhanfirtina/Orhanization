using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Security.Entities;


namespace Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.Users.Commands.Create;

public class CreatedUserWithClaimsResponse
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public ICollection<UserOperationClaim> UserOperationClaims { get; set; }
    public ICollection<UserDepositor> UserDepositors { get; set; }
}
