using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDefaults.Constants;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDefaults.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDefaults.Constants.ActionParameterDefaultOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDefaults;

public class GetByIdActionParameterDefaultQuery : IRequest<GetByIdActionParameterDefaultResponse>, ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string[] Roles => [Admin, User, Read];	

    public Guid Id { get; set; }
    public ActionParameterDefaultsDetailLevel DetailLevel { get; set; }



    public class GetByIdActionParameterDefaultQueryHandler : IRequestHandler<GetByIdActionParameterDefaultQuery, GetByIdActionParameterDefaultResponse>
    {
        private readonly IActionParameterDefaultRepository _actionParameterDefaultRepository;
        private readonly ActionParameterDefaultBusinessRules _actionParameterDefaultBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdActionParameterDefaultQueryHandler(IActionParameterDefaultRepository actionParameterDefaultRepository, IMapper mapper, ActionParameterDefaultBusinessRules actionParameterDefaultBusinessRules)
        {
            _actionParameterDefaultRepository = actionParameterDefaultRepository;
            _mapper = mapper;
            _actionParameterDefaultBusinessRules = actionParameterDefaultBusinessRules;
        }

        public async Task<GetByIdActionParameterDefaultResponse> Handle(GetByIdActionParameterDefaultQuery request, CancellationToken cancellationToken)
        {
            _actionParameterDefaultBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            if (request.DetailLevel.AnyPropertyTrue())
            {
                return _mapper.Map<GetByIdActionParameterDefaultResponse>(await _actionParameterDefaultRepository.GetAsync(x => x.Id == request.Id,
                include: x =>
                {
                    IQueryable<ActionParameterDefault> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeActionParameter)
                    {
                        query = query.Include(x => x.ActionParameter);
                    }

                    if (detailLevel.IncludeDepositorCompany)
                    {
                        query = query.Include(x => x.DepositorCompany);
                    }

                    var includableQuery = query as IIncludableQueryable<ActionParameterDefault, object>;
                    return includableQuery;
                },
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
            else
            {
                return _mapper.Map<GetByIdActionParameterDefaultResponse>(await _actionParameterDefaultRepository.GetAsync(x => x.Id == request.Id,
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
        }
    }
}
