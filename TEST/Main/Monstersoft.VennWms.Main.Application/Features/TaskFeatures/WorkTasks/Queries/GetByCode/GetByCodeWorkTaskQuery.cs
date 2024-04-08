using AutoMapper;
using MediatR;
using Monstersoft.VennWms.Main.Application.Features.TaskFeatures.WorkTasks.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.TaskRepositories;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.TaskFeatures.WorkTasks.Constants.WorkTaskOperationClaims;


namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.WorkTasks.Queries.GetByCode;

public class GetByCodeWorkTaskQuery : IRequest<GetByCodeWorkTaskResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public string Code { get; set; }


    public class GetByCodeWorkTaskQueryHandler : IRequestHandler<GetByCodeWorkTaskQuery, GetByCodeWorkTaskResponse>
    {
        private readonly IWorkTaskRepository _workTaskRepository;
        private readonly WorkTaskBusinessRules _workTaskBusinessRules;
        private readonly IMapper _mapper;

        public GetByCodeWorkTaskQueryHandler(IWorkTaskRepository workTaskRepository, IMapper mapper, WorkTaskBusinessRules workTaskBusinessRules)
        {
            _workTaskRepository = workTaskRepository;
            _mapper = mapper;
            _workTaskBusinessRules = workTaskBusinessRules;
        }

        public async Task<GetByCodeWorkTaskResponse> Handle(GetByCodeWorkTaskQuery request, CancellationToken cancellationToken)
        {
            _workTaskBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            Guid depositorCompanyId = Guid.Parse(request.UserRequestInfo.RequestUserLocalityId);

            return _mapper.Map<GetByCodeWorkTaskResponse>(await _workTaskRepository.GetAsync(
            predicate: x => x.Code == request.Code && x.DepositorCompanyId == depositorCompanyId,
            withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}

