using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributes.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributes.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributes.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.ProductControllers;

public class ProductAttributeController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateProductAttributeCommand createProductAttributeCommand)
    {
        CreatedProductAttributeResponse response = await Mediator.Send(createProductAttributeCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateProductAttributeCommand updateProductAttributeCommand)
    {
        UpdatedProductAttributeResponse response = await Mediator.Send(updateProductAttributeCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteProductAttributeCommand deleteProductAttributeCommand)
    {
        DeletedProductAttributeResponse response = await Mediator.Send(deleteProductAttributeCommand);
        return Ok(response);
    }
}

