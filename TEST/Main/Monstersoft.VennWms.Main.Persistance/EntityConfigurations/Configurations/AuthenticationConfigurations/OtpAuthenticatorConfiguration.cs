using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Orhanization.Core.Security.Entities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.AuthenticationConfigurations;

public class OtpAuthenticatorConfiguration : IEntityTypeConfiguration<OtpAuthenticator>
{
    public void Configure(EntityTypeBuilder<OtpAuthenticator> builder)
    {
        builder.ToTable("OtpAuthenticators").HasKey(e => e.Id);
        builder.Property(e => e.UserId).HasColumnName("UserId");
        builder.Property(e => e.Id).HasColumnName("Id").UseIdentityColumn(1, 1);
        builder.Property(e => e.SecretKey).HasColumnName("SecretKey");
        builder.Property(e => e.IsVerified).HasColumnName("IsVerified");
        builder.HasOne(e => e.User);
    }
}
