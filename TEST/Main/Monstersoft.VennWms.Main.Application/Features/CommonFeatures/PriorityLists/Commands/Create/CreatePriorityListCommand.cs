using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.PriorityLists.Constants;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.PriorityLists.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.PriorityLists.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.CommonFeatures.PriorityLists.Constants.PriorityListOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.PriorityLists.Commands.Create;

public class CreatePriorityListCommand : IRequest<CreatedPriorityListResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string[] Roles => [Admin, User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetPriorityLists"];

    public CreatePriorityListDto PriorityList { get; set; }
    public PriorityListsDetailLevel DetailLevel { get; set; }


    public class CreatePriorityListCommandHandler : IRequestHandler<CreatePriorityListCommand, CreatedPriorityListResponse>
    {
        private readonly IPriorityListRepository _priorityListRepository;
        private readonly PriorityListBusinessRules _priorityListBusinessRules;
        private readonly IMapper _mapper;

        public CreatePriorityListCommandHandler(IPriorityListRepository priorityListRepository, IMapper mapper, PriorityListBusinessRules priorityListBusinessRules)
        {
            _priorityListRepository = priorityListRepository;
            _mapper = mapper;
            _priorityListBusinessRules = priorityListBusinessRules;
        }

        public async Task<CreatedPriorityListResponse> Handle(CreatePriorityListCommand request, CancellationToken cancellationToken)
        {
            _priorityListBusinessRules.CreateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            PriorityList priorityList = _mapper.Map<PriorityList>(request.PriorityList);
            priorityList.CreatedDate = DateTime.Now;

            PriorityList createdRecord = await _priorityListRepository.AddAsync(priorityList);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _priorityListRepository.GetAsync(predicate: x => x.Id == createdRecord.Id,
                include: x =>
                {
                    IQueryable<PriorityList> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeDepositorCompany)
                    {
                        query = query.Include(y => y.DepositorCompany);
                    }


                    var includableQuery = query as IIncludableQueryable<PriorityList, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<CreatedPriorityListResponse>(response);
            }
            else
            {
                var response = await _priorityListRepository.GetAsync(predicate: x => x.Id == createdRecord.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedPriorityListResponse>(response);

            }
        }
    }
}



