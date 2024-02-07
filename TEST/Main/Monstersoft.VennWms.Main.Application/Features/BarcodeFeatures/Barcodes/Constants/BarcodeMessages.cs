using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Constants;

public class BarcodeMessages
{
    public const string BarcodeCodeExists = "Bu mudi için barkod kodu zaten tanımlı.";
    public const string BarcodeCodeNotExists = "Bu barkod koduna ait kayıt bulunamadı.";
    public const string BarcodeActiveIdNotExists = "Bu barkod Id sine ait aktif kayıt bulunamadı.";
    public const string BarcodeCodeIsDeleted = "Bu barkod koduna ait kayıt silinmiş.";
    public const string DepositorIsNotHaveBarcode = "Bu mudiye ait kayıt nulunamadı.";
    public const string DeleteRequestExecutedSuccessfully = "Barkod başarıyla silindi.";
}
