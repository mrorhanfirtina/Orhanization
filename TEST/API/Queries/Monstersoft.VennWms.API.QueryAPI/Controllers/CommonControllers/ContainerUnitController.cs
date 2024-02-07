using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Queries.GetById;

namespace Monstersoft.VennWms.API.QueryAPI.Controllers.CommonControllers
{
    public class ContainerUnitController : BaseController
    {
        [HttpGet("{depositorCode}/{code}")]
        public async Task<IActionResult> GetByCodeAsync([FromRoute] string depositorCode, [FromRoute] string code)
        {
            GetByCodeContainerUnitQuery query = new() { Code = code, DepositorCode = depositorCode };

            GetByCodeContainerUnitResponse result = await Mediator.Send(query);

            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync([FromRoute] int id)
        {
            GetByIdContainerUnitQuery query = new() { Id = id };

            GetByIdContainerUnitResponse result = await Mediator.Send(query);

            return Ok(result);
        }
    }
}
