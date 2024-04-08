using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Orhanization.Core.Security.Entities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.AuthenticationConfigurations;

public class UserOperationClaimConfiguration : IEntityTypeConfiguration<UserOperationClaim>
{
    public void Configure(EntityTypeBuilder<UserOperationClaim> builder)
    {
        builder.ToTable("UserOperationClaims").HasKey(u => u.Id);
        builder.Property(u => u.Id).HasColumnName("Id").UseIdentityColumn(1, 1);
        builder.Property(u => u.UserId).HasColumnName("UserId");
        builder.Property(u => u.OperationClaimId).HasColumnName("OperationClaimId");
        builder
            .HasIndex(indexExpression: u => new { u.UserId, u.OperationClaimId }, name: "UK_UserOperationClaims_UserId_OperationClaimId")
            .IsUnique();
        builder.HasOne(u => u.User);
        builder.HasOne(u => u.OperationClaim);
    }
}
