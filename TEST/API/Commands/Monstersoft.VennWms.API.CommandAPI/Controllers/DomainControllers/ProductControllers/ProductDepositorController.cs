using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductDepositors.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductDepositors.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductDepositors.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.ProductControllers;

public class ProductDepositorController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateProductDepositorCommand createProductDepositorCommand)
    {
        CreatedProductDepositorResponse response = await Mediator.Send(createProductDepositorCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateProductDepositorCommand updateProductDepositorCommand)
    {
        UpdatedProductDepositorResponse response = await Mediator.Send(updateProductDepositorCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteProductDepositorCommand deleteProductDepositorCommand)
    {
        DeletedProductDepositorResponse response = await Mediator.Send(deleteProductDepositorCommand);
        return Ok(response);
    }
}

