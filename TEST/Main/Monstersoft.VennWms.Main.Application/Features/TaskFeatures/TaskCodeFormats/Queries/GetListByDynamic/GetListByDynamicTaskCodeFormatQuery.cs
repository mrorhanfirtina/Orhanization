using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskCodeFormats.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.TaskRepositories;
using Monstersoft.VennWms.Main.Domain.Entities.TaskEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using Orhanization.Core.Application.Requests;
using Orhanization.Core.Application.Response;
using Orhanization.Core.Persistence.Dynamic;
using Orhanization.Core.Persistence.Paging;
using static Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TransactionTypes.Constants.TaskCodeFormatOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.TaskCodeFormats.Queries.GetListByDynamic;

public class GetListByDynamicTaskCodeFormatQuery : IRequest<GetListResponse<GetListByDynamicTaskCodeFormatListItemDto>>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public PageRequest PageRequest { get; set; }
    public DynamicQuery DynamicQuery { get; set; }


    public class GetListByDynamicTaskCodeFormatQueryHandler : IRequestHandler<GetListByDynamicTaskCodeFormatQuery, GetListResponse<GetListByDynamicTaskCodeFormatListItemDto>>
    {
        private readonly ITaskCodeFormatRepository _taskCodeFormatRepository;
        private readonly TaskCodeFormatBusinessRules _taskCodeFormatBusinessRules;
        private readonly IMapper _mapper;

        public GetListByDynamicTaskCodeFormatQueryHandler(ITaskCodeFormatRepository taskCodeFormatRepository, IMapper mapper, TaskCodeFormatBusinessRules taskCodeFormatBusinessRules)
        {
            _taskCodeFormatRepository = taskCodeFormatRepository;
            _taskCodeFormatBusinessRules = taskCodeFormatBusinessRules;
            _mapper = mapper;
        }

        public async Task<GetListResponse<GetListByDynamicTaskCodeFormatListItemDto>> Handle(GetListByDynamicTaskCodeFormatQuery request, CancellationToken cancellationToken)
        {
            _taskCodeFormatBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            Paginate<TaskCodeFormat> taskCodeFormatList = await _taskCodeFormatRepository.GetListByDynamicAsync(
            dynamic: request.DynamicQuery, predicate: m => m.DepositorCompanyId == depositorCompanyId,
            index: request.PageRequest.PageIndex,
            size: request.PageRequest.PageSize, cancellationToken: cancellationToken);

            return _mapper.Map<GetListResponse<GetListByDynamicTaskCodeFormatListItemDto>>(taskCodeFormatList);
        }
    }

}
