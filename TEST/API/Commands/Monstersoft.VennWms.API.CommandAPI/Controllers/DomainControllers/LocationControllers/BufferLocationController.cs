using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.BufferLocations.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.BufferLocations.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.LocationFeatures.BufferLocations.Commands.Update;

namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.LocationControllers;

public class BufferLocationController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateBufferLocationCommand createBufferLocationCommand)
    {
        CreatedBufferLocationResponse response = await Mediator.Send(createBufferLocationCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateBufferLocationCommand updateBufferLocationCommand)
    {
        UpdatedBufferLocationResponse response = await Mediator.Send(updateBufferLocationCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteBufferLocationCommand deleteBufferLocationCommand)
    {
        DeletedBufferLocationResponse response = await Mediator.Send(deleteBufferLocationCommand);
        return Ok(response);
    }
}

