using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Constants;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Rules;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.UnsuitReasons.Commands.Create;
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

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ContainerUnits.Commands.Create;

public class CreateContainerUnitCommand : IRequest<CreatedContainerUnitResponse>, ITransactionalRequest, 
    ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetContainerUnits";
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }


    public CreateContainerUnitDto? ContainerUnit { get; set; }
    public ContainerUnitDetaillevel DetailLevel { get; set; }



    public class CreateContainerUnitCommandHandler : IRequestHandler<CreateContainerUnitCommand, CreatedContainerUnitResponse>
    {
        private readonly IContainerUnitRepository _containerUnitRepository;
        private readonly ContainerUnitBusinessRules _containerUnitBusinessRules;
        private readonly IMapper _mapper;

        public CreateContainerUnitCommandHandler(IContainerUnitRepository containerUnitRepository, IMapper mapper, ContainerUnitBusinessRules containerUnitBusinessRules)
        {
            _containerUnitRepository = containerUnitRepository;
            _mapper = mapper;
            _containerUnitBusinessRules = containerUnitBusinessRules;
        }

        public async Task<CreatedContainerUnitResponse> Handle(CreateContainerUnitCommand request, CancellationToken cancellationToken)
        {
            _containerUnitBusinessRules.CreateRequest()
                .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
                .CheckCodeExistenceWhenCreate(request.ContainerUnit.Code);

            ContainerUnit containerUnit = _mapper.Map<ContainerUnit>(request.ContainerUnit);
            containerUnit.DepositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);
            containerUnit.CreatedDate = DateTime.Now;

            ContainerUnit createdRecord = await _containerUnitRepository.AddAsync(containerUnit);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _containerUnitRepository.GetAsync(predicate: x => x.Id == createdRecord.Id,
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

                return _mapper.Map<CreatedContainerUnitResponse>(response);
            }
            else
            {
                var response = await _containerUnitRepository.GetAsync(predicate: x => x.Id == createdRecord.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedContainerUnitResponse>(response);

            }
        }
    }

}


