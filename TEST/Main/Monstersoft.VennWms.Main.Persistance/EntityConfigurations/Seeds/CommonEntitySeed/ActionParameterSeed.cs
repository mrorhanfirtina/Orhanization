using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;

namespace Monstersoft.VennWms.Main.Persistance.EntityConfigurations.Seeds.CommonEntitySeed;

public class ActionParameterSeed : IEntityTypeConfiguration<ActionParameter>
{
    public void Configure(EntityTypeBuilder<ActionParameter> builder)
    {
        builder.HasData(
            new ActionParameter
            {
                Id = 1,
                CategoryId = 1,
                CreatedDate = DateTime.Now,
                Name = "RequireFullLocationCode",
                Description = @"Girilen lokasyon kodunu yanlızca birebir lokasyonla eşleşiyor olması durumunda kabul edecektir.",
                DefaultValue = "true"
            },
            new ActionParameter
            {
                Id = 2,
                CategoryId = 1,
                CreatedDate = DateTime.Now,
                Name = "KeepSSCCLeadingZeroes",
                Description = @"Normal durumlarda sistem eğer girilen SSCC değeri 20 veya daha büyükse değerin başındaki 00 ları görmezden gelir. Bu parametre kullanıldığında SSCC başındaki 00 ile işlem görecektir.",
                DefaultValue = "false"
            },
            new ActionParameter
            {
                Id = 3,
                CategoryId = 1,
                CreatedDate = DateTime.Now,
                Name = "IgnoreBarcodeQuantity",
                Description = @"Bir barkod şeridi taratıldığında miktar alanı varsa görmezden gelinip kullanıcıdan miktar istenmesini sağlar.",
                DefaultValue = "false"
            },
            new ActionParameter
            {
                Id = 4,
                CategoryId = 4,
                CreatedDate = DateTime.Now,
                Name = "AcceptAnyLocation",
                Description = @"Beklenen teslim almaların yalnızca alım için seçilmiş lokasyonlara değil, herhangi bir lokasyona yapılmasına izin verir.",
                DefaultValue = "false"
            },
            new ActionParameter
            {
                Id = 5,
                CategoryId = 4,
                CreatedDate = DateTime.Now,
                Name = "ProposeExpectedLocation",
                Description = @"Beklenen Teslim alma kalemleri için önerilen lokasyonları otomatik hedef lokasyonu alanına getirir.",
                DefaultValue = "false"
            },
            new ActionParameter
            {
                Id = 6,
                CategoryId = 4,
                CreatedDate = DateTime.Now,
                Name = "ForceExpectedLocation",
                Description = @"Beklenen Teslim alma kalemleri için zorunlu lokasyonları kullanır.",
                DefaultValue = "false"
            },
            new ActionParameter
            {
                Id = 7,
                CategoryId = 4,
                CreatedDate = DateTime.Now,
                Name = "GetLocationLast",
                Description = @"Beklenen Teslim alma kalemleri için son teslim alınan lokasyonları getirir.",
                DefaultValue = "false"
            },
            new ActionParameter
            {
                Id = 8,
                CategoryId = 4,
                CreatedDate = DateTime.Now,
                Name = "DisplayLastReceiptCode",
                Description = @"Beklenen teslim almalar için son teslim alınan kodu getirir.",
                DefaultValue = "false"
            },
            new ActionParameter
            {
                Id = 9,
                CategoryId = 4,
                CreatedDate = DateTime.Now,
                Name = "ForbidReceiveCompleted",
                Description = @"Beklenen teslim almaların tamamlanmış olanlarının statüsünü değiştirmez.",
                DefaultValue = "false"
            },
            new ActionParameter
            {
                Id = 10,
                CategoryId = 4,
                CreatedDate = DateTime.Now,
                Name = "SuppressCompletedWarning",
                Description = @"Tamamlanmış olan teslim almalara girilmeye çalışıldığında gösterilecek olan uyarıyı baskılar.",
                DefaultValue = "false"
            },
            new ActionParameter
            {
                Id = 11,
                CategoryId = 4,
                CreatedDate = DateTime.Now,
                Name = "KeepSSCC",
                Description = @"SSCC numarasını korur, sıradaki işlemde otomatik getirir.",
                DefaultValue = "false"
            },
            new ActionParameter
            {
                Id = 12,
                CategoryId = 4,
                CreatedDate = DateTime.Now,
                Name = "ShowAllPalletTypes",
                Description = @"Teslim almada tüm palet tiplerini getirir.",
                DefaultValue = "false"
            },
            new ActionParameter
            {
                Id = 13,
                CategoryId = 4,
                CreatedDate = DateTime.Now,
                Name = "ExcludePackingTypes",
                Description = @"Alım yapılacak palet türünü seçerken, paketleme konteyneri olarak işaretlenmiş palet türleri hariç tutulur.",
                DefaultValue = "false"
            },
            new ActionParameter
            {
                Id = 14,
                CategoryId = 1,
                CreatedDate = DateTime.Now,
                Name = "ForceQuantity",
                Description = @"Parametrede girilen miktar değeri zorunlu hale getirir. Kullanıcıya miktar sormaz.",
                DefaultValue = "-1"
            },
            new ActionParameter
            {
                Id = 15,
                CategoryId = 4,
                CreatedDate = DateTime.Now,
                Name = "SkipNewItemWarning",
                Description = @"Beklenen teslim almada olmayan yeni ürün uyarısını atlar.",
                DefaultValue = "false"
            },
            new ActionParameter
            {
                Id = 16,
                CategoryId = 4,
                CreatedDate = DateTime.Now,
                Name = "SkipExcessWarning",
                Description = @"Beklenen teslim almada fazla ürün miktarı uyarısını atlar.",
                DefaultValue = "false"
            },
            new ActionParameter
            {
                Id = 17,
                CategoryId = 4,
                CreatedDate = DateTime.Now,
                Name = "ForbidExcess",
                Description = @"Fazla miktarı veya yeni ürün alımını engeller/izin verir. 0- Fazla miktarı veya yeni ürün alımını engeller. 1- Sadece beklenen teslim almada bulunan fazla miktarın aşımını sağlar. 2- Fazla miktarı engeller ancak yeni ürün alımına izin verir. 3- Fazla miktarı ve yeni ürün alımına izin verir.",
                DefaultValue = "0"
            }
            );
    }
}
