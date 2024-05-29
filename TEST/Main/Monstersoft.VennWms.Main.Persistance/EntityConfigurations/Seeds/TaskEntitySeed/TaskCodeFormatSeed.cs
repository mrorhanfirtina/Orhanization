using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.TaskEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.TaskEntitySeed;

public class TaskCodeFormatSeed : IEntityTypeConfiguration<TaskCodeFormat>
{
    public void Configure(EntityTypeBuilder<TaskCodeFormat> builder)
    {
        builder.HasData(
        new TaskCodeFormat
        {
            Id = Guid.Parse("073ef3b0-91e6-4c66-a1b3-2c3e42961741"),
            Code = "PT",
            TransactionTypeId = 2,
            TaskFormat = "PT{00000000}",
            TaskCounter = 1,
            TaskListFormat = "PT{00000000}",
            TaskListCounter = 1,
            DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            CreatedDate = DateTime.Now,
        },

        new TaskCodeFormat
        {
            Id = Guid.Parse("0b8d4375-38b9-48eb-b169-5a606ba3ef71"),
            Code = "PC",
            TransactionTypeId = 3,
            TaskFormat = "PC{00000000}",
            TaskCounter = 1,
            TaskListFormat = "PC{00000000}",
            TaskListCounter = 1,
            DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            CreatedDate = DateTime.Now,
        },

        new TaskCodeFormat
        {
            Id = Guid.Parse("1fc0577b-bc37-4a92-a4f9-64fa0fd27020"),
            Code = "RL",
            TransactionTypeId = 7,
            TaskFormat = "RL{00000000}",
            TaskCounter = 1,
            TaskListFormat = "RL{00000000}",
            TaskListCounter = 1,
            DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            CreatedDate = DateTime.Now,
        },

        new TaskCodeFormat
        {
            Id = Guid.Parse("2bb3acb0-045c-4dc6-82f1-cb25ddd0812e"),
            Code = "LD",
            TransactionTypeId = 9,
            TaskFormat = "LD{00000000}",
            TaskCounter = 1,
            TaskListFormat = "LD{00000000}",
            TaskListCounter = 1,
            DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            CreatedDate = DateTime.Now,
        },

        new TaskCodeFormat
        {
            Id = Guid.Parse("adb3b346-ed95-4fa2-ba5c-39d954974296"),
            Code = "RP",
            TransactionTypeId = 10,
            TaskFormat = "RP{00000000}",
            TaskCounter = 1,
            TaskListFormat = "RP{00000000}",
            TaskListCounter = 1,
            DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            CreatedDate = DateTime.Now,
        },

        new TaskCodeFormat
        {
            Id = Guid.Parse("dd284a98-4d33-44af-92b8-955f09194155"),
            Code = "RM",
            TransactionTypeId = 11,
            TaskFormat = "RM{00000000}",
            TaskCounter = 1,
            TaskListFormat = "RM{00000000}",
            TaskListCounter = 1,
            DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            CreatedDate = DateTime.Now,
        }

        );
    }
}
