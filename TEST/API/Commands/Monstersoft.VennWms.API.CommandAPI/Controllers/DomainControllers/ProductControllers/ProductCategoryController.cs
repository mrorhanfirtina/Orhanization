using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategories.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategories.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategories.Commands.Update;

namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.ProductControllers;

public class ProductCategoryController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateProductCategoryCommand createProductCategoryCommand)
    {
        CreatedProductCategoryResponse response = await Mediator.Send(createProductCategoryCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateProductCategoryCommand updateProductCategoryCommand)
    {
        UpdatedProductCategoryResponse response = await Mediator.Send(updateProductCategoryCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteProductCategoryCommand deleteProductCategoryCommand)
    {
        DeletedProductCategoryResponse response = await Mediator.Send(deleteProductCategoryCommand);
        return Ok(response);
    }
}


