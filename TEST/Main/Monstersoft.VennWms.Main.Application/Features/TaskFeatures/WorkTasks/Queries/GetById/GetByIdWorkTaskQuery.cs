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


namespace Monstersoft.VennWms.Main.Application.Features.TaskFeatures.WorkTasks.Queries.GetById;

public class GetByIdWorkTaskQuery : IRequest<GetByIdWorkTaskResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];

    public Guid Id { get; set; }


    public class GetByIdWorkTaskQueryHandler : IRequestHandler<GetByIdWorkTaskQuery, GetByIdWorkTaskResponse>
    {
        private readonly IWorkTaskRepository _workTaskRepository;
        private readonly WorkTaskBusinessRules _workTaskBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdWorkTaskQueryHandler(IWorkTaskRepository workTaskRepository, IMapper mapper, WorkTaskBusinessRules workTaskBusinessRules)
        {
            _workTaskRepository = workTaskRepository;
            _mapper = mapper;
            _workTaskBusinessRules = workTaskBusinessRules;
        }

        public async Task<GetByIdWorkTaskResponse> Handle(GetByIdWorkTaskQuery request, CancellationToken cancellationToken)
        {
            _workTaskBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            return _mapper.Map<GetByIdWorkTaskResponse>(await _workTaskRepository.GetAsync(x => x.Id == request.Id, withDeleted: false, cancellationToken: cancellationToken));
        }
    }

}

