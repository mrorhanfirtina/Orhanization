using AutoMapper;
using Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.Auth.Commands.RevokeToken;
using Orhanization.Core.Security.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.Auth.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<RefreshToken, RevokedTokenResponse>().ReverseMap();
    }
}

