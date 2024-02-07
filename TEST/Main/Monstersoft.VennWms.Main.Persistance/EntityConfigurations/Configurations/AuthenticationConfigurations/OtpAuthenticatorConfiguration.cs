using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using Orhanization.Core.Security.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
