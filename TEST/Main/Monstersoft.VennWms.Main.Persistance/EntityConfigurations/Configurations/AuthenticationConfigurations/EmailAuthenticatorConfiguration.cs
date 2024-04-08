using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Orhanization.Core.Security.Entities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.AuthenticationConfigurations;

public class EmailAuthenticatorConfiguration : IEntityTypeConfiguration<EmailAuthenticator>
{
    public void Configure(EntityTypeBuilder<EmailAuthenticator> builder)
    {
        builder.ToTable("EmailAuthenticators").HasKey(e => e.Id);
        builder.Property(e => e.UserId).HasColumnName("UserId");
        builder.Property(e => e.Id).HasColumnName("Id").UseIdentityColumn(1, 1);
        builder.Property(e => e.ActivationKey).HasColumnName("ActivationKey");
        builder.Property(e => e.IsVerified).HasColumnName("IsVerified");
        builder.HasOne(e => e.User);
    }
}
