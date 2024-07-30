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
using Orhanization.Core.Application.Pipelines.Caching;
using Orhanization.Core.Application.Pipelines.Locality;
using Orhanization.Core.Application.Pipelines.Logging;
using Orhanization.Core.Application.Pipelines.Transaction;
using static Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDefaults.Constants.ActionParameterDefaultOperationClaims;

namespace Monstersoft.VennWms.Main.Application.Features.CommonFeatures.ActionParameterDefaults;

public class UpdateActionParameterDefaultCommand : IRequest<UpdatedActionParameterDefaultResponse>, ITransactionalRequest, ICacheRemoveRequest, ILoggableRequest, ISecuredRequest, ILocalityRequest
{
    public string[] Roles => [Admin, User, ActionParameterDefaultOperationClaims.Update, Write];	
    public UserRequestInfo? UserRequestInfo { get; set; }
    public string? CacheKey => "";
    public bool ByPassCache => false;
    public string[]? CacheGroupKey => ["GetActionParameterDefaults"];

    public UpdateActionParameterDefaultDto ActionParameterDefault { get; set; }
    public ActionParameterDefaultsDetailLevel DetailLevel { get; set; }



    public class UpdateActionParameterDefaultCommandHandler : IRequestHandler<UpdateActionParameterDefaultCommand, UpdatedActionParameterDefaultResponse>
    {
        private readonly IActionParameterDefaultRepository _actionParameterDefaultRepository;
        private readonly ActionParameterDefaultBusinessRules _actionParameterDefaultBusinessRules;
        private readonly IMapper _mapper;

        public UpdateActionParameterDefaultCommandHandler(IActionParameterDefaultRepository actionParameterDefaultRepository, ActionParameterDefaultBusinessRules actionParameterDefaultBusinessRules, IMapper mapper)
        {
            _actionParameterDefaultRepository = actionParameterDefaultRepository;
            _actionParameterDefaultBusinessRules = actionParameterDefaultBusinessRules;
            _mapper = mapper;
        }

        public async Task<UpdatedActionParameterDefaultResponse> Handle(UpdateActionParameterDefaultCommand request, CancellationToken cancellationToken)
        {
            _actionParameterDefaultBusinessRules.UpdateRequest()
            .CheckDepositorCompany(request.UserRequestInfo.RequestUserLocalityId)
            .CheckIdExistence(request.ActionParameterDefault.Id);


            ActionParameterDefault? currentActionParameterDefault = await _actionParameterDefaultRepository.GetAsync(predicate: x => x.Id == request.ActionParameterDefault.Id);

            ActionParameterDefault? actionParameterDefault = _mapper.Map(request.ActionParameterDefault, currentActionParameterDefault);
            actionParameterDefault.UpdatedDate = DateTime.Now;

            await _actionParameterDefaultRepository.UpdateAsync(actionParameterDefault);

            if (request.DetailLevel.AnyPropertyTrue())
            {
                var response = await _actionParameterDefaultRepository.GetAsync(predicate: x => x.Id == actionParameterDefault.Id,
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
                }, enableTracking: false, cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedActionParameterDefaultResponse>(response);
            }
            else
            {
                var response = await _actionParameterDefaultRepository.GetAsync(predicate: x => x.Id == actionParameterDefault.Id,
                enableTracking: false,
                cancellationToken: cancellationToken);

                return _mapper.Map<UpdatedActionParameterDefaultResponse>(response);
            }
        }
    }
}
