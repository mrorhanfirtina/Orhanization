using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.PriorityLists.Commands.Create;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.PriorityLists.Constants;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.PriorityLists.Dtos.UpdateDtos;
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

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.PriorityLists.Commands.Update;

public class UpdatePriorityListCommand : IRequest<UpdatedPriorityListResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, Write, PriorityListOperationClaims.Update];
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string? CacheGroupKey => "GetPriorityLists";

    public UpdatePriorityListDto PriorityList { get; set; }
    public PriorityListDetailLevel DetailLevel { get; set; }

    public class UpdatePriorityListCommandHandler : IRequestHandler<UpdatePriorityListCommand, UpdatedPriorityListResponse>
    {
        private readonly IPriorityListRepository _priorityListRepository;
        private readonly PriorityListBusinessRules _priorityListBusinessRules;
        private readonly IMapper _mapper;

        public UpdatePriorityListCommandHandler(IPriorityListRepository priorityListRepository, PriorityListBusinessRules priorityListBusinessRules, IMapper mapper)
        {
            _priorityListRepository = priorityListRepository;
            _priorityListBusinessRules = priorityListBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedPriorityListResponse> Handle(UpdatePriorityListCommand request, CancellationToken cancellationToken)
        {
            _priorityListBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            PriorityList? currentPriorityList = await _priorityListRepository.GetAsync(predicate: x => x.Id == request.PriorityList.Id);

            PriorityList? priorityList = _mapper.Map(request.PriorityList, currentPriorityList);
            priorityList.UpdatedDate = DateTime.Now;

            await _priorityListRepository.UpdateAsync(priorityList);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _priorityListRepository.GetAsync(predicate: x => x.Id == priorityList.Id,
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

                return _mapper.Map<UpdatedPriorityListResponse>(response);
            }
            else
            {
                var response = await _priorityListRepository.GetAsync(predicate: x => x.Id == priorityList.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedPriorityListResponse>(response);
            }
        }
    }
}



