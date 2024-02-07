using Amazon.Runtime.Internal;
using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Rules;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Queries.GetByCode;

public class GetByCodeContainerUnitQuery : IRequest<GetByCodeContainerUnitResponse>, ITransactionalRequest, ILoggableRequest
{
    public string Code { get; set; }
    public string DepositorCode { get; set; }
}

public class GetByCodeQueryHandler : IRequestHandler<GetByCodeContainerUnitQuery, GetByCodeContainerUnitResponse>
{
    private readonly IContainerUnitRepository _containerUnitRepository;
    private readonly IMapper _mapper;
    private readonly DepositorBusinessRules _depositorBusinessRules;
    private readonly ContainerUnitBusinessRules _containerUnitBusinessRules;

    public GetByCodeQueryHandler(IContainerUnitRepository containerUnitRepository, IMapper mapper, DepositorBusinessRules depositorBusinessRules, ContainerUnitBusinessRules containerUnitBusinessRules)
    {
        _containerUnitRepository = containerUnitRepository;
        _mapper = mapper;
        _depositorBusinessRules = depositorBusinessRules;
        _containerUnitBusinessRules = containerUnitBusinessRules;
    }

    public async Task<GetByCodeContainerUnitResponse> Handle(GetByCodeContainerUnitQuery request, CancellationToken cancellationToken)
    {
        // Depositor kod mevcut mu?
        Depositor? depositor = await _depositorBusinessRules.DepositorCodeMustBeValid(request.DepositorCode);

        // ContainerUnit kod mevcut mu?
        await _containerUnitBusinessRules.IsContainerUnitCodeExists(request.Code, depositor.Id);

        // ContainerUnit koduna ait kaydı getir
        ContainerUnit? containerUnit = await _containerUnitRepository.GetAsync(predicate: p => p.Code.ToLower() == request.Code.ToLower()
                                                                   && p.DepositorId == depositor.Id && p.DeletedDate == null);

        // Response oluştur
        var response = _mapper.Map<GetByCodeContainerUnitResponse>(containerUnit);
        response.DepositorCode = depositor.Code;

        // Response döndür
        return response;
    }
}
