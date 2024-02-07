using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Constants;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Printers.Constants;
using Monstersoft.VennWms.Main.Application.Repositories.BarcodeRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.BarcodeEntities;
using Nest;
using Orhanization.Core.Application.Rules;
using Orhanization.Core.CrossCuttingConcerns.Exceptions.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Printers.Rules;

public class PrinterBusinessRules : BaseBusinessRules
{
    private readonly IPrinterRepository _printerRepository;

    public PrinterBusinessRules(IPrinterRepository printerRepository)
    {
        _printerRepository = printerRepository;
    }

    //Printer update işlemi sırasında barkod içinde printer kodu mükkerrer mi?
    public async Task PrinterCodeCannotBeDuplicatedWhenUpdate(string code, Guid barcodeId)
    {
        Printer? result = await _printerRepository.GetAsync(predicate: p => p.Code == code
                                                       && p.BarcodeId == barcodeId);

        if (result != null)
        {
            throw new BusinessException(PrinterMessages.PrinterCodeExists);
        }
    }

    //Printer insert işlemi öncesi gelen veride aynı kodda başka printer kaydı var mı?(Mükkerrer kayıt mı?)
    public async Task PrinterCodeCannotBeDuplicatedWhenInsert(ICollection<Printer> printers)
    {
        var groupedByCode = from p in printers
                            group p by p.Code into g
                            select new
                            {
                                Code = g.Key,
                                BCount = g.Count()
                            };


        foreach (var item in groupedByCode)
        {
            if (item.BCount > 1)
            {
                throw new BusinessException(PrinterMessages.PrinterCodeExists);
            }
        }
    }
}
