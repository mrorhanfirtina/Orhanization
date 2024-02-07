using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Rules;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Queries.GetById;

public class GetByIdContainerUnitQuery : IRequest<GetByIdContainerUnitResponse>, ITransactionalRequest, ILoggableRequest
{
    public int Id { get; set; }
}

public class GetByIdContainerUnitQueryHandler : IRequestHandler<GetByIdContainerUnitQuery, GetByIdContainerUnitResponse>
{
    private readonly IContainerUnitRepository _containerUnitRepository;
    private readonly IMapper _mapper;
    private readonly DepositorBusinessRules _depositorBusinessRules;
    private readonly ContainerUnitBusinessRules _containerUnitBusinessRules;

    public GetByIdContainerUnitQueryHandler(IContainerUnitRepository containerUnitRepository, IMapper mapper, DepositorBusinessRules depositorBusinessRules, ContainerUnitBusinessRules containerUnitBusinessRules)
    {
        _containerUnitRepository = containerUnitRepository;
        _mapper = mapper;
        _depositorBusinessRules = depositorBusinessRules;
        _containerUnitBusinessRules = containerUnitBusinessRules;
    }

    public async Task<GetByIdContainerUnitResponse> Handle(GetByIdContainerUnitQuery request, CancellationToken cancellationToken)
    {
        
        await _containerUnitBusinessRules.IsContainerUnitIdExists(request.Id);

        ContainerUnit? containerUnit = await _containerUnitRepository.GetAsync(predicate: p => p.Id == request.Id && p.DeletedDate == null);

        Depositor depositor = await _depositorBusinessRules.DepositorIdMustBeValid(containerUnit.DepositorId);

        var response = _mapper.Map<GetByIdContainerUnitResponse>(containerUnit);
        response.DepositorCode = depositor.Code;

        return response;
    }
}
