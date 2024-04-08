using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductBarcodes.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductBarcodes.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductBarcodes.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.ProductControllers;

public class ProductBarcodeController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateProductBarcodeCommand createProductBarcodeCommand)
    {
        CreatedProductBarcodeResponse response = await Mediator.Send(createProductBarcodeCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateProductBarcodeCommand updateProductBarcodeCommand)
    {
        UpdatedProductBarcodeResponse response = await Mediator.Send(updateProductBarcodeCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteProductBarcodeCommand deleteProductBarcodeCommand)
    {
        DeletedProductBarcodeResponse response = await Mediator.Send(deleteProductBarcodeCommand);
        return Ok(response);
    }
}

