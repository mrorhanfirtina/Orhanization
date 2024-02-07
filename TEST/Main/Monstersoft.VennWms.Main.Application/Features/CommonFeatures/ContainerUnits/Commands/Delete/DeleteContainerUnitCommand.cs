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

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Commands.Delete;

public class DeleteContainerUnitCommand : IRequest<DeletedContainerUnitResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest
{
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetContainerUnits";
    public string Code { get; set; }
    public string DepositorCode { get; set; }
}

public class DeleteContainerUnitCommandHandler : IRequestHandler<DeleteContainerUnitCommand, DeletedContainerUnitResponse>
{
    private readonly DepositorBusinessRules _depositorBusinessRules;
    private readonly ContainerUnitBusinessRules _containerUnitBusinessRules;
    private readonly IContainerUnitRepository _containerUnitRepository;
    private readonly IMapper _mapper;

    public DeleteContainerUnitCommandHandler(DepositorBusinessRules depositorBusinessRules, IContainerUnitRepository containerUnitRepository, IMapper mapper, ContainerUnitBusinessRules containerUnitBusinessRules)
    {
        _depositorBusinessRules = depositorBusinessRules;
        _containerUnitRepository = containerUnitRepository;
        _mapper = mapper;
        _containerUnitBusinessRules = containerUnitBusinessRules;
    }
    public async Task<DeletedContainerUnitResponse> Handle(DeleteContainerUnitCommand request, CancellationToken cancellationToken)
    {
        //Depositor kodu geçerli mi?
        Depositor? depositor = await _depositorBusinessRules.DepositorCodeMustBeValid(request.DepositorCode);

        //ContainerUnit kodu geçerli mi?
        await _containerUnitBusinessRules.ContainerUnitCodeMustBeValidWhenDelete(request.Code, depositor.Id);

        //ContainerUnit çekme işlemi
        ContainerUnit? containerUnit = await _containerUnitRepository.GetAsync(predicate: p => p.Code == request.Code && p.DepositorId == depositor.Id && p.DeletedDate == null);

        //ContainerUnit silme işlemi
        await _containerUnitRepository.DeleteAsync(containerUnit);

        //Response oluşturma
        var response = _mapper.Map<DeletedContainerUnitResponse>(containerUnit);
        response.DepositorCode = depositor.Code;
        response.Message = "Konteyner birimi başarıyla silindi.";
        response.IsSuccess = true;

        //Response dönüşü
        return response;
    }
}

