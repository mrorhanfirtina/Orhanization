using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Extensions;

public static class ContainerUnitExtensions
{
    public static string GenereteNewSSCC(this ContainerUnit containerUnit, IContainerUnitRepository containerUnitRepository)
    {
        string firstDigit = containerUnit.FirstDigit;
        string counter = (Convert.ToInt32(containerUnit.Counter) + 1).ToString().PadLeft(7, '0');
        string producerCode = containerUnit.ProducerCode.PadLeft(7, '0');
        string countryCode = containerUnit.CountryCode.PadLeft(2, '0');

        int newCounter = (Convert.ToInt32(containerUnit.Counter) + 1);

        containerUnit.Counter = newCounter.ToString();

        containerUnitRepository.Update(containerUnit);

        string sscc = $"{firstDigit}{countryCode}{producerCode}{counter}";

        return sscc + sscc.CalculateCheckDigit();
    }

    private static string CalculateCheckDigit(this string sscc)
    {
        int total = 0;
        for (int i = 0; i < sscc.Length; i++)
        {
            int digit = int.Parse(sscc[sscc.Length - 1 - i].ToString());
            if (i % 2 == 0)
            {
                total += digit;
            }
            else
            {
                int doubled = digit * 2;
                total += (doubled > 9) ? (doubled - 9) : doubled;
            }
        }

        int checkDigit = (10 - total % 10) % 10;

        return checkDigit.ToString();
    }
}


/*
 * SSCC (Serial Shipping Container Code) için doğrulama kodu, Luhn algoritması 
 * kullanılarak hesaplanır. Bu algoritma, bir sayı dizisinin geçerliliğini doğrulamak için 
 * genellikle kredi kartları ve benzeri tanımlayıcı numaralarda kullanılır. SSCC'nin 
 * doğrulama kodu hesaplama süreci şu adımlardan oluşur:
 * 
 * SSCC'nin İlk 17 Hanesini Tersine Çevir: Doğrulama kodunu hesaplarken, SSCC'nin ilk 
 * 17 hanesini sağdan sola doğru tersine çeviririz. Örneğin, SSCC'nin ilk 17 hanesi 
 * 12345678901234567 ise, bu tersine çevrildiğinde 76543210987654321 olur.
 * 
 * Her İkinci Haneyi İkiye Katla: Ters çevrilmiş numaranın her ikinci hanesini (yani orijinal 
 * numarada soldan sağa her ikinci hane) ikiye katlayın. Eğer çarpım sonucu 9'dan 
 * büyükse, elde edilen iki basamağı toplayın.
 * 
 * Tüm Rakamları Toplayın: Bu işlemden sonra elde edilen tüm rakamları toplayın.
 * 
 * Toplamı 10'a Tamamlama: Elde edilen toplamı, bir üstteki 10'un katına tamamlayacak 
 * şekilde bir sayı bulun. Bu sayı, SSCC'nin doğrulama kodudur. 
 */