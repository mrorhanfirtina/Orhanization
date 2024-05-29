using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategoryLists.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategoryLists.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategoryLists.Commands.Update;
using Monstersoft.VennWms.Main.Application.Features.ProductFeatures.ProductCategoryLists;

namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.ProductControllers;

public class ProductCategoryListController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateProductCategoryListCommand createProductCategoryListCommand)
    {
        CreatedProductCategoryListResponse response = await Mediator.Send(createProductCategoryListCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateProductCategoryListCommand updateProductCategoryListCommand)
    {
        UpdatedProductCategoryListResponse response = await Mediator.Send(updateProductCategoryListCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteProductCategoryListCommand deleteProductCategoryListCommand)
    {
        DeletedProductCategoryListResponse response = await Mediator.Send(deleteProductCategoryListCommand);
        return Ok(response);
    }
}


