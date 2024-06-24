using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.POEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.PurchaseOrderEntitySeed;

public class PurchaseOrderSeed : IEntityTypeConfiguration<PurchaseOrder>
{
    public void Configure(EntityTypeBuilder<PurchaseOrder> builder)
    {
        builder.HasData(
        new PurchaseOrder
        {
            Id = Guid.Parse("20be69f3-1c3d-4916-8499-f7d6deca1bfb"),
            Code = "466116385",
            SupplierId = Guid.Parse("52196CDB-6B73-46FA-B5B6-0CEFBD92D9F1"),
            DepositorId = Guid.Parse("202D64F3-4474-4B55-B30D-61C430799EFA"),
            DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            PoTypeId = Guid.Parse("46ec506e-b979-4261-8227-056aebab69f2"),
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },

        new PurchaseOrder
        {
            Id = Guid.Parse("61789239-097b-40f8-af15-3dcd8c778314"),
            Code = "196133977",
            SupplierId = Guid.Parse("C447AEC7-67D4-4DCB-9194-431D4CFEC230"),
            DepositorId = Guid.Parse("202D64F3-4474-4B55-B30D-61C430799EFA"),
            DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            PoTypeId = Guid.Parse("46ec506e-b979-4261-8227-056aebab69f2"),
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },

        new PurchaseOrder
        {
            Id = Guid.Parse("4814a111-d13f-41b5-a1e9-f46ad15f7e1a"),
            Code = "291085201",
            SupplierId = Guid.Parse("99EB6D09-F61F-4F6D-9335-6F569DF2241F"),
            DepositorId = Guid.Parse("2F7E0D11-04A0-4111-A0C3-FA1DC049E823"),
            DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            PoTypeId = Guid.Parse("46ec506e-b979-4261-8227-056aebab69f2"),
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },

        new PurchaseOrder
        {
            Id = Guid.Parse("13b2fb88-addd-490e-b38a-9f3e3b1f840e"),
            Code = "152785489",
            SupplierId = Guid.Parse("D09A7AEE-FD18-4ED7-8C26-63387FEC682C"),
            DepositorId = Guid.Parse("2F7E0D11-04A0-4111-A0C3-FA1DC049E823"),
            DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            PoTypeId = Guid.Parse("46ec506e-b979-4261-8227-056aebab69f2"),
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },

        new PurchaseOrder
        {
            Id = Guid.Parse("f2485ca7-051f-4a4c-b6cd-38144a434e3e"),
            Code = "433236157",
            SupplierId = Guid.Parse("12F10A2F-BD9E-4822-8989-6C96C9D30BB4"),
            DepositorId = Guid.Parse("2F7E0D11-04A0-4111-A0C3-FA1DC049E823"),
            DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            PoTypeId = Guid.Parse("46ec506e-b979-4261-8227-056aebab69f2"),
            StatusId = 1,
            CreatedDate = DateTime.Now,
        }

        );
    }
}
