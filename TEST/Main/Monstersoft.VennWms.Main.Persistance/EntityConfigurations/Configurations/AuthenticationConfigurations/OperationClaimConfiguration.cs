using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Orhanization.Core.Security.Constants;
using Orhanization.Core.Security.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.AuthenticationConfigurations;

public class OperationClaimConfiguration : IEntityTypeConfiguration<OperationClaim>
{
    public void Configure(EntityTypeBuilder<OperationClaim> builder)
    {
        builder.ToTable("OperationClaims").HasKey(o => o.Id);
        builder.Property(o => o.Id).HasColumnName("Id").UseIdentityColumn(1, 1);
        builder.Property(o => o.Name).HasColumnName("Name");
        builder.HasIndex(indexExpression: o => o.Name, name: "UK_OperationClaims_Name").IsUnique();
    }
}
