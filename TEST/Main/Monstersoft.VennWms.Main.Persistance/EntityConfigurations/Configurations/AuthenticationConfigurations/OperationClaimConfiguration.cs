using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Orhanization.Core.Security.Entities;

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
