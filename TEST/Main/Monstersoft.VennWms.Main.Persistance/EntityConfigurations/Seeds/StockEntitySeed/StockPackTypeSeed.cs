using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.StockEntitySeed;

public class StockPackTypeSeed : IEntityTypeConfiguration<StockPackType>
{
    public void Configure(EntityTypeBuilder<StockPackType> builder)
    {
        builder.HasData(
            new StockPackType
            {
                Id = Guid.Parse("16B9AECB-9E18-4EF4-A36F-04C871E21DFE"),
                StockId = Guid.Parse("3437D9FC-D394-45AB-8EC7-27CF622D8484"),
                ItemUnitId = Guid.Parse("EDDE5B4E-F2AF-4888-A50C-E2096FD84E3B"),
                Quantity = 2m,
                QuantityFree = 2m,
                PackTypeRatio = 2m,
                ParentId = null,
                CUQuantity = 30,
                CUQuantityFree = 30,
                CreatedDate = DateTime.Now,
            },
            new StockPackType
            {
                Id = Guid.Parse("18EB054A-D75D-4373-8125-0A8D4C2DE794"),
                StockId = Guid.Parse("3437D9FC-D394-45AB-8EC7-27CF622D8484"),
                ItemUnitId = Guid.Parse("A32B5522-B666-489A-8751-F36E35F329B6"),
                Quantity = 30m,
                QuantityFree = 30m,
                PackTypeRatio = 15m,
                ParentId = Guid.Parse("16B9AECB-9E18-4EF4-A36F-04C871E21DFE"),
                CUQuantity = null,
                CUQuantityFree = null,
                CreatedDate = DateTime.Now,
            },
            new StockPackType
            {
                Id = Guid.Parse("8365784F-60CD-44BB-AF1A-F1A2796221BA"),
                StockId = Guid.Parse("3DC167DB-2010-4B61-BFA3-2B3C200789D9"),
                ItemUnitId = Guid.Parse("5E11E7E2-03A9-429B-9583-0877C2F4C31F"),
                Quantity = 2m,
                QuantityFree = 2m,
                PackTypeRatio = 2m,
                ParentId = null,
                CUQuantity = 10,
                CUQuantityFree = 10,
                CreatedDate = DateTime.Now,
            },
            new StockPackType
            {
                Id = Guid.Parse("E4C46AEF-3DA2-45F1-9297-71D5FC07354C"),
                StockId = Guid.Parse("3DC167DB-2010-4B61-BFA3-2B3C200789D9"),
                ItemUnitId = Guid.Parse("7563B910-54DD-402B-8E87-12B3A6CCF85C"),
                Quantity = 10m,
                QuantityFree = 10m,
                PackTypeRatio = 5m,
                ParentId = Guid.Parse("8365784F-60CD-44BB-AF1A-F1A2796221BA"),
                CUQuantity = null,
                CUQuantityFree = null,
                CreatedDate = DateTime.Now,
            },
            new StockPackType
            {
                Id = Guid.Parse("9FCB7410-D900-4F17-B650-5C365D0BF14B"),
                StockId = Guid.Parse("471B8449-2BA3-4F41-A726-6D9206F40AC0"),
                ItemUnitId = Guid.Parse("04752347-C443-4303-B576-C78027D8A0D9"),
                Quantity = 20m,
                QuantityFree = 20m,
                PackTypeRatio = 10m,
                ParentId = Guid.Parse("F8486A74-6BF0-45BE-A9E1-A4ED05EA1867"),
                CUQuantity = null,
                CUQuantityFree = null,
                CreatedDate = DateTime.Now,
            },
            new StockPackType
            {
                Id = Guid.Parse("F8486A74-6BF0-45BE-A9E1-A4ED05EA1867"),
                StockId = Guid.Parse("471B8449-2BA3-4F41-A726-6D9206F40AC0"),
                ItemUnitId = Guid.Parse("539C9A7A-D5AC-490A-898A-C1741DAEAA3F"),
                Quantity = 2m,
                QuantityFree = 2m,
                PackTypeRatio = 2m,
                ParentId = null,
                CUQuantity = 20,
                CUQuantityFree = 20,
                CreatedDate = DateTime.Now,
            },
            new StockPackType
            {
                Id = Guid.Parse("37F4695A-D4D3-44A4-8ACA-1A8E53AD7D39"),
                StockId = Guid.Parse("64D678B6-67A6-4290-BB43-AF6A889EB383"),
                ItemUnitId = Guid.Parse("D15267BB-D7F5-438C-B194-847032C8513B"),
                Quantity = 240m,
                QuantityFree = 240m,
                PackTypeRatio = 20m,
                ParentId = Guid.Parse("BD933DD7-6092-464C-9601-D71A22646094"),
                CUQuantity = null,
                CUQuantityFree = null,
                CreatedDate = DateTime.Now,
            },
            new StockPackType
            {
                Id = Guid.Parse("BD933DD7-6092-464C-9601-D71A22646094"),
                StockId = Guid.Parse("64D678B6-67A6-4290-BB43-AF6A889EB383"),
                ItemUnitId = Guid.Parse("52884777-2380-4C27-B2A3-59FF9DFB6B7D"),
                Quantity = 12m,
                QuantityFree = 12m,
                PackTypeRatio = 12m,
                ParentId = null,
                CUQuantity = 240,
                CUQuantityFree = 240,
                CreatedDate = DateTime.Now,
            },
            new StockPackType
            {
                Id = Guid.Parse("2DB37D59-A06C-4CFE-B362-84F4E1C37248"),
                StockId = Guid.Parse("7792A3AC-494A-4A27-934E-99A8530C2640"),
                ItemUnitId = Guid.Parse("C81EFF75-5756-446E-9881-6C7CCA16EA58"),
                Quantity = 10m,
                QuantityFree = 10m,
                PackTypeRatio = 10m,
                ParentId = Guid.Parse("6346D100-C8AA-4894-A75E-8981BE5ED37C"),
                CUQuantity = null,
                CUQuantityFree = null,
                CreatedDate = DateTime.Now,
            },
            new StockPackType
            {
                Id = Guid.Parse("6346D100-C8AA-4894-A75E-8981BE5ED37C"),
                StockId = Guid.Parse("7792A3AC-494A-4A27-934E-99A8530C2640"),
                ItemUnitId = Guid.Parse("80D5986F-742C-4A2C-86B4-258B1B10F808"),
                Quantity = 1m,
                QuantityFree = 1m,
                PackTypeRatio = 1m,
                ParentId = null,
                CUQuantity = 10,
                CUQuantityFree = 10,
                CreatedDate = DateTime.Now,
            },
            new StockPackType
            {
                Id = Guid.Parse("28547869-0E0F-4E8A-8569-69354887BCD0"),
                StockId = Guid.Parse("BF35AEC9-2510-419D-9A43-9959A5ABA873"),
                ItemUnitId = Guid.Parse("4913E935-6ABC-48B6-AA09-C52919875B0C"),
                Quantity = 240m,
                QuantityFree = 240m,
                PackTypeRatio = 240m,
                ParentId = Guid.Parse("6FF625A7-AB47-43B7-A5D3-76DEA6B7E254"),
                CUQuantity = null,
                CUQuantityFree = null,
                CreatedDate = DateTime.Now,
            },
            new StockPackType
            {
                Id = Guid.Parse("6FF625A7-AB47-43B7-A5D3-76DEA6B7E254"),
                StockId = Guid.Parse("BF35AEC9-2510-419D-9A43-9959A5ABA873"),
                ItemUnitId = Guid.Parse("41DE7A60-8689-4F76-80DF-FFB67E6B8D45"),
                Quantity = 1m,
                QuantityFree = 1m,
                PackTypeRatio = 1m,
                ParentId = null,
                CUQuantity = 240,
                CUQuantityFree = 240,
                CreatedDate = DateTime.Now,
            },
            new StockPackType
            {
                Id = Guid.Parse("2F53526C-8016-44B1-92FE-3DF04B76EEAA"),
                StockId = Guid.Parse("E261F800-03DB-4734-89FD-C49B40335EF4"),
                ItemUnitId = Guid.Parse("B0D16F0A-F693-4429-B31F-ED50B9EF7CDC"),
                Quantity = 1m,
                QuantityFree = 1m,
                PackTypeRatio = 1m,
                ParentId = null,
                CUQuantity = 10,
                CUQuantityFree = 10,
                CreatedDate = DateTime.Now,
            },
            new StockPackType
            {
                Id = Guid.Parse("790094A9-20CA-4805-943F-30143DDC9C05"),
                StockId = Guid.Parse("E261F800-03DB-4734-89FD-C49B40335EF4"),
                ItemUnitId = Guid.Parse("146DF446-ED3B-435B-8E11-9D4E57EBC025"),
                Quantity = 10m,
                QuantityFree = 10m,
                PackTypeRatio = 10m,
                ParentId = Guid.Parse("2F53526C-8016-44B1-92FE-3DF04B76EEAA"),
                CUQuantity = null,
                CUQuantityFree = null,
                CreatedDate = DateTime.Now,
            },
            new StockPackType
            {
                Id = Guid.Parse("0C1D2E11-1E3B-4008-9027-15C260FEE98A"),
                StockId = Guid.Parse("E519D3FF-8D8C-4EA2-92EE-2FF46C581897"),
                ItemUnitId = Guid.Parse("0222A6D5-371B-4E3B-A03B-AFFEB37B3D1E"),
                Quantity = 432m,
                QuantityFree = 432m,
                PackTypeRatio = 12m,
                ParentId = Guid.Parse("DFC4B82A-9520-4758-9745-E946AA54FB94"),
                CUQuantity = null,
                CUQuantityFree = null,
                CreatedDate = DateTime.Now,
            },
            new StockPackType
            {
                Id = Guid.Parse("DFC4B82A-9520-4758-9745-E946AA54FB94"),
                StockId = Guid.Parse("E519D3FF-8D8C-4EA2-92EE-2FF46C581897"),
                ItemUnitId = Guid.Parse("39385DC7-A950-48D8-A2F2-D13AB91AEE10"),
                Quantity = 36m,
                QuantityFree = 36m,
                PackTypeRatio = 36m,
                ParentId = null,
                CUQuantity = 432,
                CUQuantityFree = 432,
                CreatedDate = DateTime.Now,
            }
        );
    }
}
