using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributeValues.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributeValues.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAttributeValues.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.ProductControllers;

public class ProductAttributeValueController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateProductAttributeValueCommand createProductAttributeValueCommand)
    {
        CreatedProductAttributeValueResponse response = await Mediator.Send(createProductAttributeValueCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateProductAttributeValueCommand updateProductAttributeValueCommand)
    {
        UpdatedProductAttributeValueResponse response = await Mediator.Send(updateProductAttributeValueCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteProductAttributeValueCommand deleteProductAttributeValueCommand)
    {
        DeletedProductAttributeValueResponse response = await Mediator.Send(deleteProductAttributeValueCommand);
        return Ok(response);
    }
}

