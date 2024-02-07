using Orhanization.Core.Security.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;


namespace Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.Users.Commands.Create;

public class CreatedUserWithClaimsResponse
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public ICollection<UserOperationClaim> UserOperationClaims { get; set; }
}
