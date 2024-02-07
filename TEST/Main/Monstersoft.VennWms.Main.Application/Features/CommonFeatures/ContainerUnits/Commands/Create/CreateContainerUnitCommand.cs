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

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Commands.Create;

public class CreateContainerUnitCommand : IRequest<CreatedContainerUnitResponse>, ITransactionalRequest, 
    ICacheRemoveRequest, ILoggableRequest
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


public class CreateContainerUnitCommandHandler : IRequestHandler<CreateContainerUnitCommand, CreatedContainerUnitResponse>
{
    private readonly IMapper _mapper;
    private readonly IContainerUnitRepository _containerUnitRepository;
    private readonly DepositorBusinessRules _depositorBusinessRules;
    private readonly ContainerUnitBusinessRules _containerUnitBusinessRules;

    public CreateContainerUnitCommandHandler(IMapper mapper, IContainerUnitRepository containerUnitRepository, DepositorBusinessRules depositorBusinessRules, ContainerUnitBusinessRules containerUnitBusinessRules)
    {
        _mapper = mapper;
        _containerUnitRepository = containerUnitRepository;
        _depositorBusinessRules = depositorBusinessRules;
        _containerUnitBusinessRules = containerUnitBusinessRules;
    }

    public async Task<CreatedContainerUnitResponse> Handle(CreateContainerUnitCommand request, CancellationToken cancellationToken)
    {
        //Depositor kontrolü
        Depositor? depositor = await _depositorBusinessRules.DepositorCodeMustBeValid(request.DepositorCode);
        
        //ContainerUnit kodunun mevcut depositor içinde halihazırda bulunup bulunmadığı kontrol edilir.
        await _containerUnitBusinessRules.ContainerUnitCodeCannotBeDuplicatedWhenInsert(request.Code, depositor.Id);

        //İstekte gelen alanlar yeni bir ContainerUnit sınıfına maplenir.
        ContainerUnit containerUnit = _mapper.Map<ContainerUnit>(request);

        //DepositorId set edilir.
        containerUnit.DepositorId = depositor.Id;
        //Oluşturma tarihi set edilir.
        containerUnit.CreatedDate = DateTime.Now;

        //ContainerUnit veritabanına eklenir.
        return _mapper.Map<CreatedContainerUnitResponse>(await _containerUnitRepository.AddAsync(containerUnit));
    }
}
