using Orhanization.Core.Application.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.OperationClaims.Queries.GetById;

public class GetByIdOperationClaimResponse : IResponse
{
    public int Id { get; set; }
    public string Name { get; set; }
}