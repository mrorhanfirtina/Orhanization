using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.CommandAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Companies.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Companies.Commands.Delete;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Companies.Commands.Update;


namespace Monstersoft.VennWms.API.CommandAPI.Controllers.DomainControllers.DepositorControllers;

public class CompanyController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateCompanyCommand createCompanyCommand)
    {
        CreatedCompanyResponse response = await Mediator.Send(createCompanyCommand);
        return Ok(response);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] UpdateCompanyCommand updateCompanyCommand)
    {
        UpdatedCompanyResponse response = await Mediator.Send(updateCompanyCommand);
        return Ok(response);
    }

    [HttpDelete]
    public async Task<IActionResult> Delete([FromBody] DeleteCompanyCommand deleteCompanyCommand)
    {
        DeletedCompanyResponse response = await Mediator.Send(deleteCompanyCommand);
        return Ok(response);
    }
}

