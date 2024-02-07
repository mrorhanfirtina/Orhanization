using Microsoft.EntityFrameworkCore;
using Orhanization.Core.Security.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nest;
using Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.OperationClaims.Constants;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds;

public class OperationClaimSeed :  IEntityTypeConfiguration<OperationClaim>
{
    public void Configure(EntityTypeBuilder<OperationClaim> builder)
    {
        builder.HasData(
                           new OperationClaim { Id = 1, Name = GeneralOperationClaims.Admin, CreatedDate = DateTime.Now },
                           new OperationClaim { Id = 2, Name = GeneralOperationClaims.User, CreatedDate = DateTime.Now },

                           new OperationClaim { Id = 3, Name = GeneralOperationClaims.Read, CreatedDate = DateTime.Now },
                           new OperationClaim { Id = 4, Name = GeneralOperationClaims.Write, CreatedDate = DateTime.Now },

                           new OperationClaim { Id = 5, Name = GeneralOperationClaims.Add, CreatedDate = DateTime.Now },
                           new OperationClaim { Id = 6, Name = GeneralOperationClaims.Update, CreatedDate = DateTime.Now },
                           new OperationClaim { Id = 7, Name = GeneralOperationClaims.Delete, CreatedDate = DateTime.Now }
                           );
    }
}
