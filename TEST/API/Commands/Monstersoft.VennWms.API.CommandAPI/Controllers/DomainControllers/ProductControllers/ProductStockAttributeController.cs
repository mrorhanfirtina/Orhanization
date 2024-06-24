using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductStockAttributes.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductStockAttributes.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductStockAttributes.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.ProductControllers;

public class ProductStockAttributeController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateProductStockAttributeCommand createProductStockAttributeCommand)
    {
        CreatedProductStockAttributeResponse response = await Mediator.Send(createProductStockAttributeCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateProductStockAttributeCommand updateProductStockAttributeCommand)
    {
        UpdatedProductStockAttributeResponse response = await Mediator.Send(updateProductStockAttributeCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteProductStockAttributeCommand deleteProductStockAttributeCommand)
    {
        DeletedProductStockAttributeResponse response = await Mediator.Send(deleteProductStockAttributeCommand);
        return Ok(response);
    }
}

