using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds;

public class LocationCodeComponentSeed : IEntityTypeConfiguration<LocationCodeComponent>
{
    public void Configure(EntityTypeBuilder<LocationCodeComponent> builder)
    {
        builder.HasData(
                  new LocationCodeComponent { Id = 1, Description = "StorageSystem", TableName = "StorageSystems", FieldName = "Code",  FieldCode = "{SS}", CreatedDate =DateTime.Now },
                  new LocationCodeComponent { Id = 2, Description = "Building", TableName = "Buildings",  FieldCode = "{BLD}", FieldName = "Code", CreatedDate =DateTime.Now },
                  new LocationCodeComponent { Id = 3, Description = "Sector", TableName = "Sectors",  FieldCode = "{SEC}", FieldName = "Code", CreatedDate =DateTime.Now },
                  new LocationCodeComponent { Id = 4, Description = "Column", TableName = "LocationCodeFormat",  FieldCode = "{COL}", FieldName = "ColumnCode", CreatedDate =DateTime.Now },
                  new LocationCodeComponent { Id = 5, Description = "Level", TableName = "LocationCodeFormat",  FieldCode = "{LEV}", FieldName = "LevelCode", CreatedDate =DateTime.Now },
                  new LocationCodeComponent { Id = 6, Description = "SubColumn", TableName = "LocationCodeFormat",  FieldCode = "{SUBCOL}", FieldName = "SubColumnCode", CreatedDate =DateTime.Now },
                  new LocationCodeComponent { Id = 7, Description = "SubLevel", TableName = "LocationCodeFormat",  FieldCode = "{SUBLEV}", FieldName = "SubLevelCode", CreatedDate =DateTime.Now },
                  new LocationCodeComponent { Id = 8, Description = "SubPosition", TableName = "LocationCodeFormat",  FieldCode = "{SUBPOS}", FieldName = "SubPositionCode", CreatedDate =DateTime.Now }
              );
    }
}
