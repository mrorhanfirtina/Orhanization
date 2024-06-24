using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.Products.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.ProductControllers;

public class ProductController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateProductCommand createProductCommand)
    {
        CreatedProductResponse response = await Mediator.Send(createProductCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateProductCommand updateProductCommand)
    {
        UpdatedProductResponse response = await Mediator.Send(updateProductCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteProductCommand deleteProductCommand)
    {
        DeletedProductResponse response = await Mediator.Send(deleteProductCommand);
        return Ok(response);
    }
}

