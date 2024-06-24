using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.StorageSystems.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.StorageSystems.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.StorageSystems.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.LocationControllers;

public class StorageSystemController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateStorageSystemCommand createStorageSystemCommand)
    {
        CreatedStorageSystemResponse response = await Mediator.Send(createStorageSystemCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateStorageSystemCommand updateStorageSystemCommand)
    {
        UpdatedStorageSystemResponse response = await Mediator.Send(updateStorageSystemCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteStorageSystemCommand deleteStorageSystemCommand)
    {
        DeletedStorageSystemResponse response = await Mediator.Send(deleteStorageSystemCommand);
        return Ok(response);
    }
}

