using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.TaskEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Configurations.TaskEntityConfigurations;

public class TaskCodeFormatConfiguration : IEntityTypeConfiguration<TaskCodeFormat>
{
    public void Configure(EntityTypeBuilder<TaskCodeFormat> builder)
    {
        #region Tablo Tanımları
        builder.ToTable("TaskCodeFormats").HasKey(p => p.Id);
        #endregion

        #region Alan Tanımları
        builder.Property(p => p.Id).HasColumnName("Id").IsRequired();
        builder.Property(p => p.Code).HasColumnName("Code").HasMaxLength(6).IsRequired();
        builder.Property(p => p.TaskFormat).HasColumnName("TaskFormat").HasMaxLength(20).IsRequired();
        builder.Property(p => p.TaskCounter).HasColumnName("TaskCounter").IsRequired();
        builder.Property(p => p.TaskListCounter).HasColumnName("TaskListCounter").HasMaxLength(20).IsRequired();
        builder.Property(p => p.TaskListFormat).HasColumnName("TaskListFormat").IsRequired();
        builder.Property(p => p.TransactionTypeId).HasColumnName("TransactionTypeId").IsRequired();
        builder.Property(p => p.DepositorCompanyId).HasColumnName("DepositorCompanyId").IsRequired();
        builder.Property(p => p.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(p => p.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(p => p.DeletedDate).HasColumnName("DeletedDate");
        #endregion

        #region Indexler
        builder.HasIndex(p => p.Id).IsUnique();
        builder.HasIndex(p => new { p.Code, p.TaskFormat, p.TaskCounter, p.TaskListCounter, p.TaskListFormat, p.TransactionTypeId, p.DepositorCompanyId, p.CreatedDate }, name: "IX_TaskCodeFormats_Areas");
        #endregion

        #region İlişki Tanımları
        builder.HasOne(p => p.TransactionType).WithMany().HasForeignKey(p => p.TransactionTypeId).OnDelete(DeleteBehavior.Restrict);
        builder.HasOne(p => p.DepositorCompany).WithMany().HasForeignKey(p => p.DepositorCompanyId).OnDelete(DeleteBehavior.Restrict);
        #endregion

        #region Filtreler
        builder.HasQueryFilter(p => !p.DeletedDate.HasValue);
        #endregion
    }
}
