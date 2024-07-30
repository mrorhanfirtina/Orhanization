using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterCategories.Constants;
using Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterCategories.Rules;
using Monstersoft.VennWms.Main.Application.Repositories.CommonRepositories;
using Monstersoft.VennWms.Main.Application.Statics;
using Monstersoft.VennWms.Main.Domain.Entities.CommonEntities;
using Orhanization.Core.Application.Dtos;
using Orhanization.Core.Application.Pipelines.Authorization;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterCategories.Constants.ActionParameterCategoryOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterCategories.Queries.GetById;

public class GetByIdActionParameterCategoryQuery : IRequest<GetByIdActionParameterCategoryResponse>
    , ITransactionalRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, ActionParameterCategoryOperationClaims.User, Read];
    public UserRequestInfo? UserRequestInfo { get; set; }

    public int Id { get; set; }
    public ActionParameterCategoryDetailLevel DetailLevel { get; set; }


    public class GetByIdActionParameterCategoryQueryHandler : IRequestHandler<GetByIdActionParameterCategoryQuery, GetByIdActionParameterCategoryResponse>
    {
        private readonly IActionParameterCategoryRepository _actionParameterCategoryRepository;
        private readonly ActionParameterCategoryBusinessRules _actionParameterCategoryBusinessRules;
        private readonly IMapper _mapper;

        public GetByIdActionParameterCategoryQueryHandler(IActionParameterCategoryRepository actionParameterCategoryRepository, IMapper mapper, ActionParameterCategoryBusinessRules actionParameterCategoryBusinessRules)
        {
            _actionParameterCategoryRepository = actionParameterCategoryRepository;
            _mapper = mapper;
            _actionParameterCategoryBusinessRules = actionParameterCategoryBusinessRules;
        }

        public async Task<GetByIdActionParameterCategoryResponse> Handle(GetByIdActionParameterCategoryQuery request, CancellationToken cancellationToken)
        {
            _actionParameterCategoryBusinessRules.GetRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.Id);

            if (ObjectExtensions.AnyPropertyTrue(request.DetailLevel))
            {
                return _mapper.Map<GetByIdActionParameterCategoryResponse>(await _actionParameterCategoryRepository.GetAsync(x => x.Id == request.Id,
                include: x =>
                {
                    IQueryable<ActionParameterCategory> query = x;

                    var detailLevel = request.DetailLevel;

                    if (detailLevel.IncludeActionParameter)
                    {
                        query = query.Include(y => y.ActionParameters);
                    }

                    var includableQuery = query as IIncludableQueryable<ActionParameterCategory, object>;
                    return includableQuery;
                },
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
            else
            {
                return _mapper.Map<GetByIdActionParameterCategoryResponse>(await _actionParameterCategoryRepository.GetAsync(x => x.Id == request.Id,
                withDeleted: false, enableTracking: false, cancellationToken: cancellationToken));
            }
        }
    }
}
