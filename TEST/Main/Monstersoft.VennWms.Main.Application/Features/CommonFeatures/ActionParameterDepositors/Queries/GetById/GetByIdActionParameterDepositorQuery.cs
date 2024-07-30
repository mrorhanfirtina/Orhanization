using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDepositors.Constants;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDepositors.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDepositors.Constants.ActionParameterDepositorOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDepositors.Queries.GetById;

public class GetByIdActionParameterDepositorQuery : IRequest<GetByIdActionParameterDepositorResponse>
    , ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, ActionParameterDepositorOperationClaims.User, Read];
    public UserRequestInfo? UserRequestInfo { get; set; }

    public Guid Id { get; set; }
    public ActionParameterDepositorDetailLevel DetailLevel { get; set; }


    public class GetByIdActionParameterDepositorQueryHandler : IRequestHandler<GetByIdActionParameterDepositorQuery, GetByIdActionParameterDepositorResponse>
    {
        private readonly IActionParameterDepositorRepository _actionParameterDepositorRepository;
        private readonly ActionParameterDepositorBusinessRules _actionParameterDepositorBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdActionParameterDepositorQueryHandler(IActionParameterDepositorRepository actionParameterDepositorRepository, IMapper mapper, ActionParameterDepositorBusinessRules actionParameterDepositorBusinessRules)
        {
            _actionParameterDepositorRepository = actionParameterDepositorRepository;
            _mapper = mapper;
            _actionParameterDepositorBusinessRules = actionParameterDepositorBusinessRules;
        }

        public async Task<GetByIdActionParameterDepositorResponse> Handle(GetByIdActionParameterDepositorQuery request, CancellationToken cancellationToken)
        {
            _actionParameterDepositorBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                return _mapper.Map<GetByIdActionParameterDepositorResponse>(await _actionParameterDepositorRepository.GetAsync(x => x.Id == request.Id,
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
                },
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
            else
            {
                return _mapper.Map<GetByIdActionParameterDepositorResponse>(await _actionParameterDepositorRepository.GetAsync(x => x.Id == request.Id,
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
        }
    }
}
