using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.ProductEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.ProductEntitySeed;

public class BarcodeSupplierSeed : IEntityTypeConfiguration<BarcodeSupplier>
{
    public void Configure(EntityTypeBuilder<BarcodeSupplier> builder)
    {
        builder.HasData(
            new BarcodeSupplier
            {
                Id = Guid.Parse("000b9397-3ef9-48c9-94d4-f984f8544d75"),
                ProductBarcodeId = Guid.Parse("5d2c6912-8884-4270-92e3-9056038c116c"),
                SupplierId = Guid.Parse("12F10A2F-BD9E-4822-8989-6C96C9D30BB4"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
            },
            new BarcodeSupplier
            {
                Id = Guid.Parse("02db692e-55a8-4bd0-8413-af9475eaac81"),
                ProductBarcodeId = Guid.Parse("07e67a00-3f6c-4b97-a5f3-ed658e0ccadd"),
                SupplierId = Guid.Parse("52196CDB-6B73-46FA-B5B6-0CEFBD92D9F1"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
            },
            new BarcodeSupplier
            {
                Id = Guid.Parse("49e5bd71-751c-448c-8fc7-db430102c097"),
                ProductBarcodeId = Guid.Parse("cdd9f5c2-31c3-4d76-9219-5e15f2e61b4c"),
                SupplierId = Guid.Parse("A0EF044F-D6A2-4D28-94A6-DEF250511182"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
            },
            new BarcodeSupplier
            {
                Id = Guid.Parse("944649bb-7a01-4e5b-9c05-2a7573ee2319"),
                ProductBarcodeId = Guid.Parse("3400aa09-e98a-40ea-a2d1-3ac4c6189117"),
                SupplierId = Guid.Parse("D09A7AEE-FD18-4ED7-8C26-63387FEC682C"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
            },
            new BarcodeSupplier
            {
                Id = Guid.Parse("ade8e75e-23d5-46cb-854b-49f4bf52b935"),
                ProductBarcodeId = Guid.Parse("a1599815-5181-4d49-862b-6b84ec35d681"),
                SupplierId = Guid.Parse("1C37BF6B-F339-46F1-90DD-90EBB9DD4EDE"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
            },
            new BarcodeSupplier
            {
                Id = Guid.Parse("afdfd08f-d8e9-4cdc-bf80-fd098e180ff5"),
                ProductBarcodeId = Guid.Parse("8571c68a-ecc3-4d2f-972b-4e8e6ae6fa8b"),
                SupplierId = Guid.Parse("99EB6D09-F61F-4F6D-9335-6F569DF2241F"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
            },
            new BarcodeSupplier
            {
                Id = Guid.Parse("bc50e18e-6dc8-4190-a643-c3e668f4a299"),
                ProductBarcodeId = Guid.Parse("c6cc2803-44ad-4675-8a6b-3cf514ae8270"),
                SupplierId = Guid.Parse("D4D7C251-A970-4B57-B659-C3B2B75E6794"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
            },
            new BarcodeSupplier
            {
                Id = Guid.Parse("d65278e7-75ba-49b6-bf02-59458f8a73ed"),
                ProductBarcodeId = Guid.Parse("31fb12a8-78e4-4875-b1ad-7ce61c86d943"),
                SupplierId = Guid.Parse("C447AEC7-67D4-4DCB-9194-431D4CFEC230"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
            },
            new BarcodeSupplier
            {
                Id = Guid.Parse("df358f2c-b22c-409d-89a5-d0c90adcb76e"),
                ProductBarcodeId = Guid.Parse("a49552f2-5bab-45f8-ba48-e1a1a87224a7"),
                SupplierId = Guid.Parse("E0491418-188A-498A-A84A-B03B7D76A611"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
            },
            new BarcodeSupplier
            {
                Id = Guid.Parse("e878866a-22a7-411d-bec5-31c44978b9ed"),
                ProductBarcodeId = Guid.Parse("bbbdcd7e-cbe1-42ed-88a7-8c1ec0e21176"),
                SupplierId = Guid.Parse("F4259A2C-F416-40F7-96AF-B03C41671FFA"),
                DepositorCompanyId = Guid.Parse("dd4d5460-8146-4e62-ac19-a74d89955dd7"),
                CreatedDate = DateTime.Now,
            }

        );
    }
}
