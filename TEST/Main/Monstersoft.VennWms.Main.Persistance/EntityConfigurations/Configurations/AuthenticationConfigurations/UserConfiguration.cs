using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Orhanization.Core.Security.Entities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.AuthenticationConfigurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("Users", "auth").HasKey(u => u.Id);
        builder.Property(u => u.Id).HasColumnName("Id").UseIdentityColumn(1, 1);
        builder.Property(u => u.FirstName).HasColumnName("FirstName");
        builder.Property(u => u.LastName).HasColumnName("LastName");
        builder.Property(u => u.Email).HasColumnName("Email");
        builder.Property(u => u.LocalityId).HasColumnName("LocalityId");
        builder.HasIndex(indexExpression: u => u.Email, name: "UK_Users_Email").IsUnique();
        builder.Property(u => u.PasswordSalt).HasColumnName("PasswordSalt");
        builder.Property(u => u.PasswordHash).HasColumnName("PasswordHash");
        builder.Property(u => u.Status).HasColumnName("Status").HasDefaultValue(true);
        builder.Property(u => u.AuthenticatorType).HasColumnName("AuthenticatorType");
    }
}

