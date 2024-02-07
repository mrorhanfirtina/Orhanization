using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Rules;
using Monstersoft.VennWms.Main.Application.Features.DepositorFeatures.Depositors.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Monstersoft.VennWms.Main.Domain.Entities.DepositorEntities;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Commands.Update;

public class UpdateContainerUnitCommand : IRequest<UpdatedContainerUnitResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest
{
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetContainerUnits";
    public string Code { get; set; }
    public string Description { get; set; }
    public string FirstDigit { get; set; }
    public string CountryCode { get; set; }
    public string ProducerCode { get; set; }
    public string Counter { get; set; }
    public string DepositorCode { get; set; }

}

public class UpdateContainerUnitCommandHandler : IRequestHandler<UpdateContainerUnitCommand, UpdatedContainerUnitResponse>
{
    private readonly IMapper _mapper;
    private readonly IContainerUnitRepository _containerUnitRepository;
    private readonly DepositorBusinessRules _depositorBusinessRules;
    private readonly ContainerUnitBusinessRules _containerUnitBusinessRules;
    
    public UpdateContainerUnitCommandHandler(IMapper mapper, IContainerUnitRepository containerUnitRepository, DepositorBusinessRules depositorBusinessRules, ContainerUnitBusinessRules containerUnitBusinessRules)
    {
        _mapper = mapper;
        _containerUnitRepository = containerUnitRepository;
        _depositorBusinessRules = depositorBusinessRules;
        _containerUnitBusinessRules = containerUnitBusinessRules;
    }

    public async Task<UpdatedContainerUnitResponse> Handle(UpdateContainerUnitCommand request, CancellationToken cancellationToken)
    {
        //Depositor kontrolü yapılır.
        Depositor? depositor = await _depositorBusinessRules.DepositorCodeMustBeValid(request.DepositorCode);
        
        //ContainerUnit kodunun mevcut depositor içinde halihazırda bulunup bulunmadığı kontrol edilir.
        ContainerUnit? containerUnit = await _containerUnitBusinessRules.ContainerUnitCodeMustBeValidWhenUpdate(request.Code, depositor.Id);

        //İstekte gelen alanlar çekilen containerUnit nesnesine maplenir.
        containerUnit = _mapper.Map(request, containerUnit);

        //Güncelleme tarihi set edilir.
        containerUnit.UpdatedDate = DateTime.Now;

        //Güncelleme işlemi gerçekleştirilir.
        var result = _mapper.Map<UpdatedContainerUnitResponse>(await _containerUnitRepository.UpdateAsync(containerUnit));
        //Depositor kodu set edilir.
        result.DepositorCode = depositor.Code;

        //Sonuç döndürülür.
        return result;
    }
}

