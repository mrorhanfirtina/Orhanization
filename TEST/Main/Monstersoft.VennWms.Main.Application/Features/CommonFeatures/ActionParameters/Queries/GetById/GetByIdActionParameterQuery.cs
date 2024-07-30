using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameters.Constants;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameters.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameters.Constants.ActionParameterOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameters.Queries.GetById;

public class GetByIdActionParameterQuery : IRequest<GetByIdActionParameterResponse>
    , ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, ActionParameterOperationClaims.User, Read];
    public UserRequestInfo? UserRequestInfo { get; set; }

    public int Id { get; set; }
    public ActionParameterDetailLevel DetailLevel { get; set; }


    public class GetByIdActionParameterQueryHandler : IRequestHandler<GetByIdActionParameterQuery, GetByIdActionParameterResponse>
    {
        private readonly IActionParameterRepository _actionParameterRepository;
        private readonly ActionParameterBusinessRules _actionParameterBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdActionParameterQueryHandler(IActionParameterRepository actionParameterRepository, IMapper mapper, ActionParameterBusinessRules actionParameterBusinessRules)
        {
            _actionParameterRepository = actionParameterRepository;
            _mapper = mapper;
            _actionParameterBusinessRules = actionParameterBusinessRules;
        }

        public async Task<GetByIdActionParameterResponse> Handle(GetByIdActionParameterQuery request, CancellationToken cancellationToken)
        {
            _actionParameterBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                return _mapper.Map<GetByIdActionParameterResponse>(await _actionParameterRepository.GetAsync(x => x.Id == request.Id,
                include: x =>
                {
                    IQueryable<ActionParameter> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeActionParameterUser)
                    {
                        query = query.Include(y => y.ActionParameterUsers);

                        if (detailLevel.ActionParameterUserDetailLevel.IncludeUser)
                        {
                            query = query.Include(y => y.ActionParameterUsers).ThenInclude(v => v.User);
                        }
                    }

                    if (detailLevel.IncludeActionParameterCategory)
                    {
                        query = query.Include(y => y.ActionParameterCategory);
                    }

                    if (detailLevel.IncludeActionParameterDepositor)
                    {
                        query = query.Include(y => y.ActionParameterDepositors);

                        if (detailLevel.ActionParameterDepositorDetailLevel.IncludeDepositor)
                        {
                            query = query.Include(y => y.ActionParameterDepositors).ThenInclude(x => x.Depositor);

                            if (detailLevel.ActionParameterDepositorDetailLevel.ActionParameterCompanyDetailLevel.IncludeCompany)
                            {
                                query = query.Include(y => y.ActionParameterDepositors).ThenInclude(x => x.Depositor).ThenInclude(v => v.Company);
                            }
                        }
                    }

                    var includableQuery = query as IIncludableQueryable<ActionParameter, object>;
                    return includableQuery;
                },
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
            else
            {
                return _mapper.Map<GetByIdActionParameterResponse>(await _actionParameterRepository.GetAsync(x => x.Id == request.Id,
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
        }
    }
}
