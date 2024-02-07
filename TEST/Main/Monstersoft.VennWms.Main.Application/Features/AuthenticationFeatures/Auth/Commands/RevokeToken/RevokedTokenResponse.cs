using Orhanization.Core.Application.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.Auth.Commands.RevokeToken;

public class RevokedTokenResponse : IResponse
{
    public int Id { get; set; }
    public string Token { get; set; }
}
