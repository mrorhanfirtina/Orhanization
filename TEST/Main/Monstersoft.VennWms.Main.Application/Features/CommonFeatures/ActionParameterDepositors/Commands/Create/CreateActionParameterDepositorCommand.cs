using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDepositors.Constants;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDepositors.Dtos.CreateDtos;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDepositors.Rules;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterUsers.Commands.Create;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDepositors.Constants.ActionParameterDepositorOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDepositors.Commands.Create;

public class CreateActionParameterDepositorCommand : IRequest<CreatedActionParameterDepositorResponse>
    , ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ILocalityRequest, ISecuredRequest
{
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetActionParameterDepositors"];
    public string[] Roles => [Admin, ActionParameterDepositorOperationClaims.User, Add, Write];
    public UserRequestInfo? UserRequestInfo { get; set; }

    public CreateActionParameterDepositorDto ActionParameterDepositor { get; set; }
    public ActionParameterDepositorDetailLevel DetailLevel { get; set; }


    public class CreateActionParameterDepositorCommandHandler : IRequestHandler<CreateActionParameterDepositorCommand, CreatedActionParameterDepositorResponse>
    {
        private readonly IActionParameterDepositorRepository _actionParameterDepositorRepository;
        private readonly ActionParameterDepositorBusinessRules _actionParameterDepositorBusinessRules;
        private readonly IMapper _mapper;

        public CreateActionParameterDepositorCommandHandler(IActionParameterDepositorRepository actionParameterDepositorRepository, IMapper mapper, ActionParameterDepositorBusinessRules actionParameterDepositorBusinessRules)
        {
            _actionParameterDepositorRepository = actionParameterDepositorRepository;
            _mapper = mapper;
            _actionParameterDepositorBusinessRules = actionParameterDepositorBusinessRules;
        }

        public async Task<CreatedActionParameterDepositorResponse> Handle(CreateActionParameterDepositorCommand request, CancellationToken cancellationToken)
        {
            _actionParameterDepositorBusinessRules.CreateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId);

            ActionParameterDepositor actionParameterDepositor = _mapper.Map<ActionParameterDepositor>(request.ActionParameterDepositor);
            actionParameterDepositor.CreatedDate = DateTime.Now;

            ActionParameterDepositor createdRecord = await _actionParameterDepositorRepository.AddAsync(actionParameterDepositor);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                var response = await _actionParameterDepositorRepository.GetAsync(predicate: x => x.Id == createdRecord.Id,
                include: x =>
                {
                    IQueryable<ActionParameterDepositor> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeActionParameter)
                    {
                        query = query.Include(y => y.ActionParameter);

                        if (detailLevel.ActionParameterDepositorParameterDetailLevel.IncludeCategory)
                        {
                            query = query.Include(y => y.ActionParameter).ThenInclude(v => v.ActionParameterCategory);
                        }
                    }

                    if (detailLevel.IncludeDepositor)
                    {
                        query = query.Include(y => y.Depositor);

                        if (detailLevel.ActionParameterDepositorDepositorDetailLevel.IncludeCompany)
                        {
                            query = query.Include(y => y.Depositor).ThenInclude(v => v.Company);
                        }
                    }

                    var includableQuery = query as IIncludableQueryable<ActionParameterDepositor, object>;
                    return includableQuery;
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<CreatedActionParameterDepositorResponse>(response);
            }
            else
            {
                var response = await _actionParameterDepositorRepository.GetAsync(predicate: x => x.Id == createdRecord.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<CreatedActionParameterDepositorResponse>(response);

            }
        }
    }
}
