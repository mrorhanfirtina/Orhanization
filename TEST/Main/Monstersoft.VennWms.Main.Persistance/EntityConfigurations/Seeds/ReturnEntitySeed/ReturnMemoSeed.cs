using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.ReturnEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.ReturnEntitySeed;

public class ReturnMemoSeed : IEntityTypeConfiguration<ReturnMemo>
{
    public void Configure(EntityTypeBuilder<ReturnMemo> builder)
    {
        builder.HasData(
        new ReturnMemo
        {
            Id = Guid.Parse("3af0628c-28c4-4ceb-98cb-34dd62ee0522"),
            ReturnId = Guid.Parse("a7bcad1b-4411-4f8d-850c-78466ef24655"),
            Description = "Test Memo 1",
            Text = "Test Memo 1 text",
            InputDate = DateTime.Now,
            CreatedDate = DateTime.Now,
        },
        new ReturnMemo
        {
            Id = Guid.Parse("5bf84daf-cc58-45ed-93f8-6d264170ed0a"),
            ReturnId = Guid.Parse("a7bcad1b-4411-4f8d-850c-78466ef24655"),
            Description = "Test Memo 2",
            Text = "Test Memo 2 text",
            InputDate = DateTime.Now,
            CreatedDate = DateTime.Now,
        }
        );
    }
}
