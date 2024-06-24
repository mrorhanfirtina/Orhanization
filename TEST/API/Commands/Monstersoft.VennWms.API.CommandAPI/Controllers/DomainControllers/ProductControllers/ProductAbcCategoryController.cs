using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAbcCategories.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAbcCategories.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductAbcCategories.Commands.Update;

namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.ProductControllers;

public class ProductAbcCategoryController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateProductAbcCategoryCommand createProductAbcCategoryCommand)
    {
        CreatedProductAbcCategoryResponse response = await Mediator.Send(createProductAbcCategoryCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateProductAbcCategoryCommand updateProductAbcCategoryCommand)
    {
        UpdatedProductAbcCategoryResponse response = await Mediator.Send(updateProductAbcCategoryCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteProductAbcCategoryCommand deleteProductAbcCategoryCommand)
    {
        DeletedProductAbcCategoryResponse response = await Mediator.Send(deleteProductAbcCategoryCommand);
        return Ok(response);
    }
}


