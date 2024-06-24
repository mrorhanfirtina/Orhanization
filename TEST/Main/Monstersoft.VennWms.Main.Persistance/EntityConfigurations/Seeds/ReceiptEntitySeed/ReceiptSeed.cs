using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.ReceiptEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.ReceiptEntitySeed;

public class ReceiptSeed : IEntityTypeConfiguration<Receipt>
{
    public void Configure(EntityTypeBuilder<Receipt> builder)
    {
        builder.HasData(
        new Receipt
        {
            Id = Guid.Parse("019c1933-01ff-4433-a5b6-054aa5cb6f9b"),
            Code = "BT20240405",
            SupplierId = Guid.Parse("12f10a2f-bd9e-4822-8989-6c96c9d30bb4"),
            DepositorId = Guid.Parse("202D64F3-4474-4B55-B30D-61C430799EFA"),
            DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            InputDate = DateTime.Now,
            PurchaseOrderId = Guid.Parse("20be69f3-1c3d-4916-8499-f7d6deca1bfb"),
            ReceiptTypeId = Guid.Parse("43d08550-0246-4508-938f-d3278a3fb358"),
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        new Receipt
        {
            Id = Guid.Parse("15fed22d-4ef2-420d-b906-af0e2f92e329"),
            Code = "BT20240407",
            SupplierId = Guid.Parse("12f10a2f-bd9e-4822-8989-6c96c9d30bb4"),
            DepositorId = Guid.Parse("2F7E0D11-04A0-4111-A0C3-FA1DC049E823"),
            DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            InputDate = DateTime.Now,
            PurchaseOrderId = Guid.Parse("4814a111-d13f-41b5-a1e9-f46ad15f7e1a"),
            ReceiptTypeId = Guid.Parse("43d08550-0246-4508-938f-d3278a3fb358"),
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        new Receipt
        {
            Id = Guid.Parse("4d400f84-652e-471f-9fdd-b1d7630855f1"),
            Code = "BT20240416",
            SupplierId = Guid.Parse("12f10a2f-bd9e-4822-8989-6c96c9d30bb4"),
            DepositorId = Guid.Parse("2F7E0D11-04A0-4111-A0C3-FA1DC049E823"),
            DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            InputDate = DateTime.Now,
            PurchaseOrderId = Guid.Parse("f2485ca7-051f-4a4c-b6cd-38144a434e3e"),
            ReceiptTypeId = Guid.Parse("43d08550-0246-4508-938f-d3278a3fb358"),
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        new Receipt
        {
            Id = Guid.Parse("4e8dd94a-bf84-4e19-89bc-e6e90aee3caf"),
            Code = "BT20240408",
            SupplierId = Guid.Parse("1c37bf6b-f339-46f1-90dd-90ebb9dd4ede"),
            DepositorId = Guid.Parse("2F7E0D11-04A0-4111-A0C3-FA1DC049E823"),
            DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            InputDate = DateTime.Now,
            PurchaseOrderId = Guid.Parse("13b2fb88-addd-490e-b38a-9f3e3b1f840e"),
            ReceiptTypeId = Guid.Parse("43d08550-0246-4508-938f-d3278a3fb358"),
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        new Receipt
        {
            Id = Guid.Parse("63d15520-a648-4cf4-bc59-f5a41b10e478"),
            Code = "BT20240411",
            SupplierId = Guid.Parse("1c37bf6b-f339-46f1-90dd-90ebb9dd4ede"),
            DepositorId = Guid.Parse("2F7E0D11-04A0-4111-A0C3-FA1DC049E823"),
            DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            InputDate = DateTime.Now,
            PurchaseOrderId = Guid.Parse("4814a111-d13f-41b5-a1e9-f46ad15f7e1a"),
            ReceiptTypeId = Guid.Parse("43d08550-0246-4508-938f-d3278a3fb358"),
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        new Receipt
        {
            Id = Guid.Parse("70c12827-9383-4dbf-9865-c64b97cec4ad"),
            Code = "BT20240418",
            SupplierId = Guid.Parse("1c37bf6b-f339-46f1-90dd-90ebb9dd4ede"),
            DepositorId = Guid.Parse("2F7E0D11-04A0-4111-A0C3-FA1DC049E823"),
            DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            InputDate = DateTime.Now,
            PurchaseOrderId = Guid.Parse("f2485ca7-051f-4a4c-b6cd-38144a434e3e"),
            ReceiptTypeId = Guid.Parse("43d08550-0246-4508-938f-d3278a3fb358"),
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        new Receipt
        {
            Id = Guid.Parse("775ad358-37a5-4b23-83e7-c586cbe77171"),
            Code = "BT20240409",
            SupplierId = Guid.Parse("1c37bf6b-f339-46f1-90dd-90ebb9dd4ede"),
            DepositorId = Guid.Parse("2F7E0D11-04A0-4111-A0C3-FA1DC049E823"),
            DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            InputDate = DateTime.Now,
            PurchaseOrderId = Guid.Parse("f2485ca7-051f-4a4c-b6cd-38144a434e3e"),
            ReceiptTypeId = Guid.Parse("43d08550-0246-4508-938f-d3278a3fb358"),
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        new Receipt
        {
            Id = Guid.Parse("942c662d-ed7d-402c-b02d-c5e53594d199"),
            Code = "BT20240414",
            SupplierId = Guid.Parse("1c37bf6b-f339-46f1-90dd-90ebb9dd4ede"),
            DepositorId = Guid.Parse("2F7E0D11-04A0-4111-A0C3-FA1DC049E823"),
            DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            InputDate = DateTime.Now,
            PurchaseOrderId = Guid.Parse("4814a111-d13f-41b5-a1e9-f46ad15f7e1a"),
            ReceiptTypeId = Guid.Parse("43d08550-0246-4508-938f-d3278a3fb358"),
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        new Receipt
        {
            Id = Guid.Parse("9a1b66f5-520b-40b6-b556-6c24f894f284"),
            Code = "BT20240417",
            SupplierId = Guid.Parse("52196cdb-6b73-46fa-b5b6-0cefbd92d9f1"),
            DepositorId = Guid.Parse("2F7E0D11-04A0-4111-A0C3-FA1DC049E823"),
            DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            InputDate = DateTime.Now,
            PurchaseOrderId = Guid.Parse("13b2fb88-addd-490e-b38a-9f3e3b1f840e"),
            ReceiptTypeId = Guid.Parse("43d08550-0246-4508-938f-d3278a3fb358"),
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        new Receipt
        {
            Id = Guid.Parse("9a9b98fa-80b9-4e94-93c6-aaa7bfb1262e"),
            Code = "BT20240410",
            SupplierId = Guid.Parse("52196cdb-6b73-46fa-b5b6-0cefbd92d9f1"),
            DepositorId = Guid.Parse("202D64F3-4474-4B55-B30D-61C430799EFA"),
            DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            InputDate = DateTime.Now,
            PurchaseOrderId = Guid.Parse("61789239-097b-40f8-af15-3dcd8c778314"),
            ReceiptTypeId = Guid.Parse("43d08550-0246-4508-938f-d3278a3fb358"),
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        new Receipt
        {
            Id = Guid.Parse("c0e64256-e82e-408f-8084-386d91381e5b"),
            Code = "BT20240406",
            SupplierId = Guid.Parse("52196cdb-6b73-46fa-b5b6-0cefbd92d9f1"),
            DepositorId = Guid.Parse("202D64F3-4474-4B55-B30D-61C430799EFA"),
            DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            InputDate = DateTime.Now,
            PurchaseOrderId = Guid.Parse("61789239-097b-40f8-af15-3dcd8c778314"),
            ReceiptTypeId = Guid.Parse("43d08550-0246-4508-938f-d3278a3fb358"),
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        new Receipt
        {
            Id = Guid.Parse("dad42b46-2e25-4262-8463-718722488bb0"),
            Code = "BT20240415",
            SupplierId = Guid.Parse("52196cdb-6b73-46fa-b5b6-0cefbd92d9f1"),
            DepositorId = Guid.Parse("2F7E0D11-04A0-4111-A0C3-FA1DC049E823"),
            DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            InputDate = DateTime.Now,
            PurchaseOrderId = Guid.Parse("13b2fb88-addd-490e-b38a-9f3e3b1f840e"),
            ReceiptTypeId = Guid.Parse("43d08550-0246-4508-938f-d3278a3fb358"),
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        new Receipt
        {
            Id = Guid.Parse("f6c46bf8-28c9-4ae4-b42c-1d1893e68e0d"),
            Code = "BT20240412",
            SupplierId = Guid.Parse("a0ef044f-d6a2-4d28-94a6-def250511182"),
            DepositorId = Guid.Parse("2F7E0D11-04A0-4111-A0C3-FA1DC049E823"),
            DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            InputDate = DateTime.Now,
            PurchaseOrderId = Guid.Parse("13b2fb88-addd-490e-b38a-9f3e3b1f840e"),
            ReceiptTypeId = Guid.Parse("43d08550-0246-4508-938f-d3278a3fb358"),
            StatusId = 1,
            CreatedDate = DateTime.Now,
        },
        new Receipt
        {
            Id = Guid.Parse("fe6f7f97-5430-4bb8-b884-b54de4d30942"),
            Code = "BT20240413",
            SupplierId = Guid.Parse("a0ef044f-d6a2-4d28-94a6-def250511182"),
            DepositorId = Guid.Parse("2F7E0D11-04A0-4111-A0C3-FA1DC049E823"),
            DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
            InputDate = DateTime.Now,
            PurchaseOrderId = Guid.Parse("f2485ca7-051f-4a4c-b6cd-38144a434e3e"),
            ReceiptTypeId = Guid.Parse("43d08550-0246-4508-938f-d3278a3fb358"),
            StatusId = 1,
            CreatedDate = DateTime.Now,
        }
        );
    }
}
