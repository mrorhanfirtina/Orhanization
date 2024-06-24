using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.StockEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.StockEntitySeed;

public class StockSeed : IEntityTypeConfiguration<Stock>
{
    public void Configure(EntityTypeBuilder<Stock> builder)
    {
        builder.HasData(
        new Stock
        {
            Id = Guid.Parse("e519d3ff-8d8c-4ea2-92ee-2ff46c581897"),
            StockContainerId = Guid.Parse("02D851EE-5883-431D-9366-F0D3F8B38F88"),
            ProductId = Guid.Parse("73A2EB51-7BF1-46EA-AEAA-08E771328BDD"),
            DepositorId = Guid.Parse("202D64F3-4474-4B55-B30D-61C430799EFA"),
            DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            CuQuantity = 432m,
            CuQuantityFree = 432m,
            LocationId = Guid.Parse("6F8A3520-FEFD-44EE-BA55-00755BDBC80A"),
            CuItemUnitId = Guid.Parse("0222A6D5-371B-4E3B-A03B-AFFEB37B3D1E"),
            CreatedDate = DateTime.Now,
        },

        new Stock
        {
            Id = Guid.Parse("64d678b6-67a6-4290-bb43-af6a889eb383"),
            StockContainerId = Guid.Parse("02FBFFCB-F4EE-4DD6-A051-6B841B7D1BA5"),
            ProductId = Guid.Parse("1D0FBE6C-D3CC-4D0F-A20A-122A1EE25190"),
            DepositorId = Guid.Parse("2F7E0D11-04A0-4111-A0C3-FA1DC049E823"),
            DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            CuQuantity = 240m,
            CuQuantityFree = 240m,
            LocationId = Guid.Parse("09BB9EAE-7A41-4655-8AEE-026089F36BB5"),
            CuItemUnitId = Guid.Parse("D15267BB-D7F5-438C-B194-847032C8513B"),
            CreatedDate = DateTime.Now,
        },
        
        new Stock
        {
            Id = Guid.Parse("bf35aec9-2510-419d-9a43-9959a5aba873"),
            StockContainerId = Guid.Parse("1F1F09A8-FE1B-48F7-9E50-19BFD47B5042"),
            ProductId = Guid.Parse("00D22996-340A-46CC-8D64-2C103CB59ACF"),
            DepositorId = Guid.Parse("202D64F3-4474-4B55-B30D-61C430799EFA"),
            DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            CuQuantity = 240m,
            CuQuantityFree = 240m,
            LocationId = Guid.Parse("75186127-4644-4BC5-B9C8-0CBD2E13EDE7"),
            CuItemUnitId = Guid.Parse("4913E935-6ABC-48B6-AA09-C52919875B0C"),
            CreatedDate = DateTime.Now,
        },
        
        new Stock
        {
            Id = Guid.Parse("3437d9fc-d394-45ab-8ec7-27cf622d8484"),
            StockContainerId = Guid.Parse("0467CBAB-2521-4613-99B4-D15B971B6E06"),
            ProductId = Guid.Parse("A276616B-F023-4D6F-87EA-DF5574BD4F9C"),
            DepositorId = Guid.Parse("202D64F3-4474-4B55-B30D-61C430799EFA"),
            DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            CuQuantity = 30m,
            CuQuantityFree = 30m,
            LocationId = Guid.Parse("CC2B3FF3-50CA-4976-A7BF-AFCF2E42B1D0"),
            CuItemUnitId = Guid.Parse("A32B5522-B666-489A-8751-F36E35F329B6"),
            CreatedDate = DateTime.Now,
        },
        
        new Stock
        {
            Id = Guid.Parse("3dc167db-2010-4b61-bfa3-2b3c200789d9"),
            StockContainerId = Guid.Parse("0467CBAB-2521-4613-99B4-D15B971B6E06"),
            ProductId = Guid.Parse("96F39E35-716A-4424-B45C-E3E9F9540034"),
            DepositorId = Guid.Parse("202D64F3-4474-4B55-B30D-61C430799EFA"),
            DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            CuQuantity = 10m,
            CuQuantityFree = 10m,
            LocationId = Guid.Parse("CC2B3FF3-50CA-4976-A7BF-AFCF2E42B1D0"),
            CuItemUnitId = Guid.Parse("7563B910-54DD-402B-8E87-12B3A6CCF85C"),
            CreatedDate = DateTime.Now,
        },
        
        new Stock
        {
            Id = Guid.Parse("e261f800-03db-4734-89fd-c49b40335ef4"),
            StockContainerId = Guid.Parse("19AB1A97-BCCF-48F0-8DDA-44D5B22241D6"),
            ProductId = Guid.Parse("93B43571-A79A-4FFE-9112-4C48B400A8A9"),
            DepositorId = Guid.Parse("2F7E0D11-04A0-4111-A0C3-FA1DC049E823"),
            DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            CuQuantity = 10m,
            CuQuantityFree = 10m,
            LocationId = Guid.Parse("0F3BA9E6-19B2-4591-90C8-C47581A328B9"),
            CuItemUnitId = Guid.Parse("146DF446-ED3B-435B-8E11-9D4E57EBC025"),
            CreatedDate = DateTime.Now,
        },
        
        new Stock
        {
            Id = Guid.Parse("471b8449-2ba3-4f41-a726-6d9206f40ac0"),
            StockContainerId = Guid.Parse("1D5085DB-E2A8-484D-9A28-B209571C4D15"),
            ProductId = Guid.Parse("9959BACC-1C42-4791-8854-2285E471D4B3"),
            DepositorId = Guid.Parse("202D64F3-4474-4B55-B30D-61C430799EFA"),
            DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            CuQuantity = 20m,
            CuQuantityFree = 20m,
            LocationId = Guid.Parse("7DF94896-CD28-4DE5-B713-CA2BE25AB179"),
            CuItemUnitId = Guid.Parse("04752347-C443-4303-B576-C78027D8A0D9"),
            CreatedDate = DateTime.Now,
        },
        
        new Stock
        {
            Id = Guid.Parse("7792a3ac-494a-4a27-934e-99a8530c2640"),
            StockContainerId = Guid.Parse("20DE0087-5399-44DD-9582-B4B071CDE019"),
            ProductId = Guid.Parse("09187E90-5E30-43AB-BD28-FA869EBBA906"),
            DepositorId = Guid.Parse("202D64F3-4474-4B55-B30D-61C430799EFA"),
            DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            CuQuantity = 10m,
            CuQuantityFree = 10m,
            LocationId = Guid.Parse("F560D34F-7BC8-4E72-85FE-CF1700B41D06"),
            CuItemUnitId = Guid.Parse("C81EFF75-5756-446E-9881-6C7CCA16EA58"),
            CreatedDate = DateTime.Now,
        }
        );
    }
}
