using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.BarcodeSuppliers.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.BarcodeSuppliers.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.BarcodeSuppliers.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.ProductControllers;

public class BarcodeSupplierController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateBarcodeSupplierCommand createBarcodeSupplierCommand)
    {
        CreatedBarcodeSupplierResponse response = await Mediator.Send(createBarcodeSupplierCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateBarcodeSupplierCommand updateBarcodeSupplierCommand)
    {
        UpdatedBarcodeSupplierResponse response = await Mediator.Send(updateBarcodeSupplierCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteBarcodeSupplierCommand deleteBarcodeSupplierCommand)
    {
        DeletedBarcodeSupplierResponse response = await Mediator.Send(deleteBarcodeSupplierCommand);
        return Ok(response);
    }
}

