using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Monstersoft.VennWms.API.QueryAPI.Controllers.Base;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Queries.GetByCode;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Queries.GetById;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Queries.GetList;
using Monstersoft.VennWms.Main.Application.Features.BarcodeFeatures.Barcodes.Queries.GetListByDynamic;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;

namespace Monstersoft.VennWms.API.QueryAPI.Controllers.BarcodeControllers
{
    public class BarcodeController : BaseController
    {
        [HttpGet("{depositorCode}/{code}")]
        public async Task<IActionResult> GetByCodeAsync([FromRoute] string depositorCode, [FromRoute] string code)
        {
            GetByCodeBarcodeQuery query = new() { Code = code};
            
            GetByCodeBarcodeResponse result = await Mediator.Send(query);

            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id)
        {
            GetByIdBarcodeQuery query = new() { Id = id };

            GetByIdBarcodeResponse result = await Mediator.Send(query);

            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            GetListBarcodeQuery query = new() { PageRequest = pageRequest};
            GetListResponse<GetListBarcodeListItemDto> response = await Mediator.Send(query);
            return Ok(response);
        }

        [HttpPost("GetListByDynamic")]
        public async Task<IActionResult> GetListByDynamic([FromQuery] PageRequest pageRequest, [FromBody] DynamicQuery? dynamicQuery = null)
        {
            GetListByDynamicBarcodeQuery query = new() { PageRequest = pageRequest, DynamicQuery = dynamicQuery };
            GetListResponse<GetListByDynamicBarcodeListItemDto> response = await Mediator.Send(query);
            return Ok(response);
        }
    }
}
