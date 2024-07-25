using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterUsers.Constants;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterUsers.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterUsers.Constants.ActionParameterUserOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures;

public class GetByIdActionParameterUserQuery : IRequest<GetByIdActionParameterUserResponse>
    , ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, ActionParameterUserOperationClaims.User, Read];
    public UserRequestInfo? UserRequestInfo { get; set; }

    public Guid Id { get; set; }
    public ActionParameterUserDetailLevel DetailLevel { get; set; }


    public class GetByIdActionParameterUserQueryHandler : IRequestHandler<GetByIdActionParameterUserQuery, GetByIdActionParameterUserResponse>
    {
        private readonly IActionParameterUserRepository _actionParameterUserRepository;
        private readonly ActionParameterUserBusinessRules _actionParameterUserBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdActionParameterUserQueryHandler(IActionParameterUserRepository actionParameterUserRepository, IMapper mapper, ActionParameterUserBusinessRules actionParameterUserBusinessRules)
        {
            _actionParameterUserRepository = actionParameterUserRepository;
            _mapper = mapper;
            _actionParameterUserBusinessRules = actionParameterUserBusinessRules;
        }

        public async Task<GetByIdActionParameterUserResponse> Handle(GetByIdActionParameterUserQuery request, CancellationToken cancellationToken)
        {
            _actionParameterUserBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                return _mapper.Map<GetByIdActionParameterUserResponse>(await _actionParameterUserRepository.GetAsync(x => x.Id == request.Id,
                include: x =>
                {
                    IQueryable<ActionParameterUser> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeActionParameter)
                    {
                        query = query.Include(y => y.ActionParameter);
                    }

                    if (detailLevel.IncludeUser)
                    {
                        query = query.Include(y => y.User);
                    }

                    var includableQuery = query as IIncludableQueryable<ActionParameterUser, object>;
                    return includableQuery;
                },
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
            else
            {
                return _mapper.Map<GetByIdActionParameterUserResponse>(await _actionParameterUserRepository.GetAsync(x => x.Id == request.Id,
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
        }
    }
}
