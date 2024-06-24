using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.DepositorCompanies.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.DepositorCompanies.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.DepositorCompanies.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.DepositorControllers;

public class DepositorCompanyController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateDepositorCompanyCommand createDepositorCompanyCommand)
    {
        CreatedDepositorCompanyResponse response = await Mediator.Send(createDepositorCompanyCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateDepositorCompanyCommand updateDepositorCompanyCommand)
    {
        UpdatedDepositorCompanyResponse response = await Mediator.Send(updateDepositorCompanyCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteDepositorCompanyCommand deleteDepositorCompanyCommand)
    {
        DeletedDepositorCompanyResponse response = await Mediator.Send(deleteDepositorCompanyCommand);
        return Ok(response);
    }
}

