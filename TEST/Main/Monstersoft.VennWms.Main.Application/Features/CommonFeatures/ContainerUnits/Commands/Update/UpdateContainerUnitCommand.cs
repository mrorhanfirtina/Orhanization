using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Constants;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Dtos.UpdateDtos;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Constants.ContainerUnitOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Commands.Update;

public class UpdateContainerUnitCommand : IRequest<UpdatedContainerUnitResponse>, ITransactionalRequest, 
    ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetContainerUnits";
    public string[] Roles => [Admin, User, Write, ContainerUnitOperationClaims.Update];
    public UserRequestInfo? UserRequestInfo { get; set; }

    public UpdateContainerUnitDto ContainerUnit { get; set; }
    public ContainerUnitDetaillevel DetailLevel { get; set; }


    public class UpdateContainerUnitCommandHandler : IRequestHandler<UpdateContainerUnitCommand, UpdatedContainerUnitResponse>
    {
        private readonly IContainerUnitRepository _containerUnitRepository;
        private readonly ContainerUnitBusinessRules _containerUnitBusinessRules;
        private readonly IMapper _mapper;

        public UpdateContainerUnitCommandHandler(IContainerUnitRepository containerUnitRepository, ContainerUnitBusinessRules containerUnitBusinessRules, IMapper mapper)
        {
            _containerUnitRepository = containerUnitRepository;
            _containerUnitBusinessRules = containerUnitBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedContainerUnitResponse> Handle(UpdateContainerUnitCommand request, CancellationToken cancellationToken)
        {
            _containerUnitBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.ContainerUnit.Id)
            .CheckCodeExistenceWhenUpdate(request.ContainerUnit.Code, request.ContainerUnit.Id);

            ContainerUnit? currentContainerUnit = await _containerUnitRepository.GetAsync(predicate: x => x.Id == request.ContainerUnit.Id);

            //İstekle gelen Dto'dan mapleme id oluşturma ve oluşturma tarihi eklemesi yapılıyor.
            ContainerUnit? containerUnit = _mapper.Map(request.ContainerUnit, currentContainerUnit);
            containerUnit.UpdatedDate = DateTime.Now;

            await _containerUnitRepository.UpdateAsync(containerUnit);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _containerUnitRepository.GetAsync(predicate: x => x.Id == containerUnit.Id,
                include: x =>
                {
                    IQueryable<ContainerUnit> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeDepositorCompany)
                    {
                        query = query.Include(y => y.DepositorCompany);
                    }


                    var includableQuery = query as IIncludableQueryable<ContainerUnit, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedContainerUnitResponse>(response);
            }
            else
            {
                var response = await _containerUnitRepository.GetAsync(predicate: x => x.Id == containerUnit.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedContainerUnitResponse>(response);

            }
        }
    }

}
