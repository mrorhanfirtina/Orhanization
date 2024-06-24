using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Application.Features.AuthenticationFeatures.OperationClaims.Constants;
using Orhanization.Core.Security.Entities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.AuthenticationSeed;

public class OperationClaimSeed : IEntityTypeConfiguration<OperationClaim>
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
                           new OperationClaim { Id = 7, Name = GeneralOperationClaims.Delete, CreatedDate = DateTime.Now },

                           new OperationClaim { Id = 8, Name = GeneralOperationClaims.Sudo, CreatedDate = DateTime.Now }
                           );
    }
}
