using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnitConversions.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnitConversions.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnitConversions.Commands.Update;

namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.CommonControllers;

public class UnitConversionController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateUnitConversionCommand createUnitConversionCommand)
    {
        CreatedUnitConversionResponse response = await Mediator.Send(createUnitConversionCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateUnitConversionCommand updateUnitConversionCommand)
    {
        UpdatedUnitConversionResponse response = await Mediator.Send(updateUnitConversionCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteUnitConversionCommand deleteUnitConversionCommand)
    {
        DeletedUnitConversionResponse response = await Mediator.Send(deleteUnitConversionCommand);
        return Ok(response);
    }
}

