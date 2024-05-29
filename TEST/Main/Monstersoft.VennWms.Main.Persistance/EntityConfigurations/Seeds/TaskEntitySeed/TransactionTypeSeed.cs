using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.TaskEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.TaskEntitySeed;

public class TransactionTypeSeed : IEntityTypeConfiguration<TransactionType>
{
    public void Configure(EntityTypeBuilder<TransactionType> builder)
    {
        builder.HasData(
        new TransactionType
        {
            Id = 1,
            Code = "01",
            Description = "Receipt",
            IsLogging = true,
            IsTaskType = false,
            IsOperational = true,
            CreatedDate = DateTime.Now,
        },
        new TransactionType
        {
            Id = 2,
            Code = "02",
            Description = "Putting",
            IsLogging = true,
            IsTaskType = true,
            IsOperational = true,
            CreatedDate = DateTime.Now,
        },
        new TransactionType
        {
            Id = 3,
            Code = "03",
            Description = "Picking",
            IsLogging = true,
            IsTaskType = true,
            IsOperational = true,
            CreatedDate = DateTime.Now,
        },
        new TransactionType
        {
            Id = 4,
            Code = "04",
            Description = "Receipt Change",
            IsLogging = true,
            IsTaskType = false,
            IsOperational = false,
            CreatedDate = DateTime.Now,
        },
        new TransactionType
        {
            Id = 5,
            Code = "05",
            Description = "Stock Change",
            IsLogging = true,
            IsTaskType = false,
            IsOperational = true,
            CreatedDate = DateTime.Now,
        },
        new TransactionType
        {
            Id = 6,
            Code = "06",
            Description = "Stock Delete",
            IsLogging = true,
            IsTaskType = false,
            IsOperational = false,
            CreatedDate = DateTime.Now,
        },
        new TransactionType
        {
            Id = 7,
            Code = "07",
            Description = "Relocate",
            IsLogging = true,
            IsTaskType = true,
            IsOperational = true,
            CreatedDate = DateTime.Now,
        },
        new TransactionType
        {
            Id = 8,
            Code = "08",
            Description = "Repack",
            IsLogging = true,
            IsTaskType = false,
            IsOperational = false,
            CreatedDate = DateTime.Now,
        },
        new TransactionType
        {
            Id = 9,
            Code = "09",
            Description = "Loading",
            IsLogging = true,
            IsTaskType = true,
            IsOperational = true,
            CreatedDate = DateTime.Now,
        },
        new TransactionType
        {
            Id = 10,
            Code = "10",
            Description = "Replenishment",
            IsLogging = true,
            IsTaskType = true,
            IsOperational = true,
            CreatedDate = DateTime.Now,
        },
        new TransactionType
        {
            Id = 11,
            Code = "11",
            Description = "Removal",
            IsLogging = true,
            IsTaskType = true,
            IsOperational = true,
            CreatedDate = DateTime.Now,
        },
        new TransactionType
        {
            Id = 12,
            Code = "12",
            Description = "Return",
            IsLogging = true,
            IsTaskType = false,
            IsOperational = true,
            CreatedDate = DateTime.Now,
        },
        new TransactionType
        {
            Id = 13,
            Code = "13",
            Description = "Allocation",
            IsLogging = true,
            IsTaskType = false,
            IsOperational = false,
            CreatedDate = DateTime.Now,
        },
        new TransactionType
        {
            Id = 14,
            Code = "14",
            Description = "Sorting",
            IsLogging = true,
            IsTaskType = false,
            IsOperational = true,
            CreatedDate = DateTime.Now,
        },
        new TransactionType
        {
            Id = 15,
            Code = "15",
            Description = "Packing",
            IsLogging = true,
            IsTaskType = false,
            IsOperational = true,
            CreatedDate = DateTime.Now,
        },
        new TransactionType
        {
            Id = 16,
            Code = "16",
            Description = "Unloading",
            IsLogging = true,
            IsTaskType = false,
            IsOperational = true,
            CreatedDate = DateTime.Now,
        },
        new TransactionType
        {
            Id = 17,
            Code = "17",
            Description = "Unpacking",
            IsLogging = true,
            IsTaskType = false,
            IsOperational = true,
            CreatedDate = DateTime.Now,
        },
        new TransactionType
        {
            Id = 18,
            Code = "18",
            Description = "Cancel Picking",
            IsLogging = true,
            IsTaskType = false,
            IsOperational = false,
            CreatedDate = DateTime.Now,
        },
        new TransactionType
        {
            Id = 19,
            Code = "19",
            Description = "Depositor Transfer",
            IsLogging = true,
            IsTaskType = false,
            IsOperational = false,
            CreatedDate = DateTime.Now,
        }
        );
    }
}
